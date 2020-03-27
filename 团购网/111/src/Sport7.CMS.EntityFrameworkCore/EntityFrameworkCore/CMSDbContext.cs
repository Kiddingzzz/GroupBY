using Announcements;
using Microsoft.EntityFrameworkCore;
using Sport7.AuditLogging.EntityFrameworkCore;
using Sport7.CMS.Comments;
using Sport7.CMS.Home;
using Sport7.CMS.HomeDictionarys;
using Sport7.CMS.Imgs;
using Sport7.CMS.TokenAuthentic;
using Sport7.CMS.Posts;
using Sport7.CMS.Tagging;
using Sport7.EntityFrameworkCore;
using Sport7.PermissionManagement.EntityFrameworkCore;
using Sport7.SettingManagement.EntityFrameworkCore;

namespace Sport7.CMS.EntityFrameworkCore
{
    public class CMSDbContext : Sport7DbContext<CMSDbContext>
    {
        public static string TablePrefix { get; set; } = CMSConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = CMSConsts.DefaultDbSchema;
        

        public DbSet<UserSession> UserSessions { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<HomeList> HomeLists { get; set; }

        public DbSet<HouseInformation> HouseInformations { get; set; }

        public DbSet<OwnerInfor> OwnerInfors { get; set; }

        public DbSet<UpdateHouse> UpdateHouses { get; set; }

        public DbSet<HomeDictionaryss> homeDictionaries { get; set; }

        public DbSet<HomeDong> HomeDongs { get; set; }

        public DbSet<HomeLayer> HomeLayers { get; set; }

        public DbSet<HomeUnit> HomeUnits { get; set; }

        public DbSet<HomeNoUnit> HomeNoUnits { get; set; }

        public DbSet<UploadImg> UploadImgs { get; set; }

        public DbSet<DanganInfer> danganInfers { get; set; }

        public DbSet<UserInfer> userInfers { get; set; }

        public CMSDbContext(DbContextOptions<CMSDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureCMS(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });


            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureAuditLogging();
        }
    }
}
