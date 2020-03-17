using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Sport7.AuditLogging.EntityFrameworkCore;
using Sport7.Autofac;
using Sport7.Data;
using Sport7.EntityFrameworkCore;
using Sport7.EntityFrameworkCore.SqlServer;
using Sport7.Localization;
using Sport7.Modularity;
using Sport7.PermissionManagement.EntityFrameworkCore;
using Sport7.Security.Claims;
using Sport7.SettingManagement.EntityFrameworkCore;
using Sport7.VirtualFileSystem;
using Sport7;
using Sport7.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Sport7.CMS.EntityFrameworkCore;
using Sport7.Threading;

namespace Sport7.CMS.Host
{
    [DependsOn(
        typeof(Sport7AutofacModule),
        typeof(CMSApplicationModule),
        typeof(CMSEntityFrameworkCoreModule),
        typeof(CMSHttpApiModule),
        typeof(Sport7PermissionManagementEntityFrameworkCoreModule),
        typeof(Sport7SettingManagementEntityFrameworkCoreModule),
        typeof(Sport7AuditLoggingEntityFrameworkCoreModule),
        typeof(Sport7EntityFrameworkCoreSqlServerModule)
        )]
    public class HostModule : Sport7Module
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.BuildConfiguration();

            context.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .SetIsOriginAllowed((host) => true)
                        .AllowCredentials());
            });

            Configure<DbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = configuration.GetConnectionString("Default");
            });

            Configure<Sport7DbContextOptions>(options =>
            {
                options.UseSqlServer();
            });

            if (hostingEnvironment.IsDevelopment())
            {
                Configure<VirtualFileSystemOptions>(options =>
                {
                    options.FileSets.ReplaceEmbeddedByPhysical<CMSDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}Sport7.CMS.Domain", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<CMSApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}Sport7.CMS.Application", Path.DirectorySeparatorChar)));
                });
            }

            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new Info { Title = "CMS API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                });

            Configure<Sport7LocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                //...add other languages
            });

            //context.Services.AddDistributedSqlServerCache(options =>
            //{
            //    options.ConnectionString = configuration.GetConnectionString("SqlServerCache");
            //    options.SchemaName = "dbo";
            //    options.TableName = "TestCache";
            //});

            context.Services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options =>
                {
                     options.Authority = configuration["AuthServer:Authority"];
                    options.ApiName = configuration["AuthServer:ApiName"];
                    options.RequireHttpsMetadata = false;
                    //TODO: Should create an extension method for that (may require to create a new ABP package depending on the IdentityServer4.AccessTokenValidation)
                    options.InboundJwtClaimTypeMap["sub"] = Sport7ClaimTypes.UserId;
                    options.InboundJwtClaimTypeMap["role"] = Sport7ClaimTypes.Role;
                    options.InboundJwtClaimTypeMap["email"] = Sport7ClaimTypes.Email;
                    options.InboundJwtClaimTypeMap["email_verified"] = Sport7ClaimTypes.EmailVerified;
                    options.InboundJwtClaimTypeMap["phone_number"] = Sport7ClaimTypes.PhoneNumber;
                    options.InboundJwtClaimTypeMap["phone_number_verified"] = Sport7ClaimTypes.PhoneNumberVerified;
                    options.InboundJwtClaimTypeMap["name"] = Sport7ClaimTypes.UserName;
                });

            Configure<Sport7AspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(CMSApplicationModule).Assembly, opts =>
                {
                    opts.RootPath = "cms";
                });
            });
			
			context.Services.AddMvc()
                .AddJsonOptions(
                options =>
                {
                    var serializerSettings = options.SerializerSettings;
                    serializerSettings.Converters.Add(new StringEnumConverter());
                    serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

                    //serializerSettings.Converters.Add(new IsoDateTimeConverter(){DateTimeFormat = "yyyy-MM-dd HH:mm:ss"});

                    serializerSettings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
                    serializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                    serializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
                    serializerSettings.NullValueHandling = NullValueHandling.Ignore;
#if DEBUG
                    serializerSettings.NullValueHandling = NullValueHandling.Include;
                    serializerSettings.Formatting = Formatting.Indented;
#endif
                }
             );
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            app.UseCors("CorsPolicy");
            app.UseVirtualFiles();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Support APP API");
            });

            app.UseAuthentication();
            app.UseSport7RequestLocalization();
            app.UseAuditing();

            app.UseMvcWithDefaultRoute();

            using (var scope = context.ServiceProvider.CreateScope())
            {
                AsyncHelper.RunSync(async () =>
                {
                    await scope.ServiceProvider
                        .GetRequiredService<IDataSeeder>()
                        .SeedAsync();
                });
            }
        }
    }
}

