﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sport7.CMS.EntityFrameworkCore;

namespace Sport7.CMS.Migrations
{
    [DbContext(typeof(CMSDbContext))]
    partial class CMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sport7.AuditLogging.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationName")
                        .HasColumnName("ApplicationName")
                        .HasMaxLength(96);

                    b.Property<string>("BrowserInfo")
                        .HasColumnName("BrowserInfo")
                        .HasMaxLength(512);

                    b.Property<string>("ClientId")
                        .HasColumnName("ClientId")
                        .HasMaxLength(64);

                    b.Property<string>("ClientIpAddress")
                        .HasColumnName("ClientIpAddress")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasColumnName("ClientName")
                        .HasMaxLength(128);

                    b.Property<string>("Comments")
                        .HasColumnName("Comments")
                        .HasMaxLength(256);

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("CorrelationId")
                        .HasColumnName("CorrelationId")
                        .HasMaxLength(64);

                    b.Property<string>("Exceptions")
                        .HasColumnName("Exceptions")
                        .HasMaxLength(4000);

                    b.Property<int>("ExecutionDuration")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("HttpMethod")
                        .HasColumnName("HttpMethod")
                        .HasMaxLength(16);

                    b.Property<int?>("HttpStatusCode")
                        .HasColumnName("HttpStatusCode");

                    b.Property<Guid?>("ImpersonatorTenantId")
                        .HasColumnName("ImpersonatorTenantId");

                    b.Property<Guid?>("ImpersonatorUserId")
                        .HasColumnName("ImpersonatorUserId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.Property<string>("TenantName");

                    b.Property<string>("Url")
                        .HasColumnName("Url")
                        .HasMaxLength(256);

                    b.Property<Guid?>("UserId")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasColumnName("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId", "ExecutionTime");

                    b.ToTable("Sport7AuditLogs");
                });

            modelBuilder.Entity("Sport7.AuditLogging.AuditLogAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuditLogId")
                        .HasColumnName("AuditLogId");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnName("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("MethodName")
                        .HasColumnName("MethodName")
                        .HasMaxLength(128);

                    b.Property<string>("Parameters")
                        .HasColumnName("Parameters")
                        .HasMaxLength(2000);

                    b.Property<string>("ServiceName")
                        .HasColumnName("ServiceName")
                        .HasMaxLength(256);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "ServiceName", "MethodName", "ExecutionTime");

                    b.ToTable("Sport7AuditLogActions");
                });

            modelBuilder.Entity("Sport7.AuditLogging.EntityChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuditLogId")
                        .HasColumnName("AuditLogId");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnName("ChangeTime");

                    b.Property<byte>("ChangeType")
                        .HasColumnName("ChangeType");

                    b.Property<string>("EntityId")
                        .IsRequired()
                        .HasColumnName("EntityId")
                        .HasMaxLength(128);

                    b.Property<Guid?>("EntityTenantId");

                    b.Property<string>("EntityTypeFullName")
                        .IsRequired()
                        .HasColumnName("EntityTypeFullName")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("TenantId", "EntityTypeFullName", "EntityId");

                    b.ToTable("Sport7EntityChanges");
                });

            modelBuilder.Entity("Sport7.AuditLogging.EntityPropertyChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EntityChangeId");

                    b.Property<string>("NewValue")
                        .HasColumnName("NewValue")
                        .HasMaxLength(512);

                    b.Property<string>("OriginalValue")
                        .HasColumnName("OriginalValue")
                        .HasMaxLength(512);

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnName("PropertyName")
                        .HasMaxLength(128);

                    b.Property<string>("PropertyTypeFullName")
                        .IsRequired()
                        .HasColumnName("PropertyTypeFullName")
                        .HasMaxLength(64);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("EntityChangeId");

                    b.ToTable("Sport7EntityPropertyChanges");
                });

            modelBuilder.Entity("Sport7.CMS.Comments.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid>("PostId");

                    b.Property<Guid?>("RepliedCommentId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Sport7.CMS.Home.HomeList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Affiliated");

                    b.Property<int>("AffiliatedArea");

                    b.Property<string>("BrightSpot");

                    b.Property<int>("BuildArea");

                    b.Property<string>("BuildFoolr");

                    b.Property<string>("BuildName");

                    b.Property<string>("BuildNumber");

                    b.Property<string>("BuildUnit");

                    b.Property<string>("Chufang");

                    b.Property<int>("CoverArea");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Elevator");

                    b.Property<string>("Fang");

                    b.Property<string>("HouseStatu");

                    b.Property<string>("HouseStructure");

                    b.Property<string>("Housecode");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<string>("JXWPerson");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Orientation");

                    b.Property<string>("Pianqu");

                    b.Property<string>("PropertyFee");

                    b.Property<string>("Purpose");

                    b.Property<string>("Renovation");

                    b.Property<string>("Ting");

                    b.Property<string>("UserName");

                    b.Property<string>("Wei");

                    b.Property<string>("Yangtai");

                    b.HasKey("Id");

                    b.ToTable("HomeList");
                });

            modelBuilder.Entity("Sport7.CMS.Home.HouseInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Buydate");

                    b.Property<int>("CenterPrice");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DiyaStatu");

                    b.Property<int>("FloorPrice");

                    b.Property<string>("GetName");

                    b.Property<Guid>("HomeListId");

                    b.Property<string>("HouseID");

                    b.Property<string>("HouseStay");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<string>("KeyCode");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("LoginName");

                    b.Property<string>("LookWay");

                    b.Property<int>("MonthRecentMoney");

                    b.Property<string>("Note");

                    b.Property<string>("Paymethod");

                    b.Property<int>("Price");

                    b.Property<int>("RecentMoney");

                    b.Property<string>("Reprice");

                    b.Property<string>("SaleStatu");

                    b.Property<string>("chanquan");

                    b.Property<string>("getHomer");

                    b.Property<string>("years");

                    b.HasKey("Id");

                    b.ToTable("HouseInformation");
                });

            modelBuilder.Entity("Sport7.CMS.Home.OwnerInfor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HomeListId");

                    b.Property<string>("IentityCard");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("OwnerName");

                    b.Property<string>("Sex");

                    b.Property<string>("phoneNumber1");

                    b.Property<string>("phoneNumber2");

                    b.HasKey("Id");

                    b.ToTable("OwnerInfor");
                });

            modelBuilder.Entity("Sport7.CMS.Home.UpdateHouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CommentTime");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HomeListId");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid>("UpdatePerson");

                    b.HasKey("Id");

                    b.ToTable("UpdateHouse");
                });

            modelBuilder.Entity("Sport7.CMS.HomeDictionarys.HomeDictionaryss", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuildingNumber");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DictionaryName");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("NumberLayer");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.Property<int>("Unit");

                    b.HasKey("Id");

                    b.ToTable("HomeDictionary");
                });

            modelBuilder.Entity("Sport7.CMS.HomeDictionarys.HomeDong", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuildingNumber");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HomeDictinaryId");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.HasKey("Id");

                    b.ToTable("HomeDong");
                });

            modelBuilder.Entity("Sport7.CMS.HomeDictionarys.HomeLayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.HasKey("Id");

                    b.ToTable("HomeLayers");
                });

            modelBuilder.Entity("Sport7.CMS.HomeDictionarys.HomeNoUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HomeDictinaryId");

                    b.Property<Guid>("HomeDongId");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsUnit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("NumberLayer");

                    b.HasKey("Id");

                    b.ToTable("HomeNoUnit");
                });

            modelBuilder.Entity("Sport7.CMS.HomeDictionarys.HomeUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HomeDictinaryId");

                    b.Property<Guid>("HomeDongId");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsUnit");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("NumberLayer");

                    b.Property<int>("Unit");

                    b.HasKey("Id");

                    b.ToTable("HomeUnit");
                });

            modelBuilder.Entity("Sport7.CMS.Imgs.UploadImg", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HouseId");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("Status");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.Property<string>("Type");

                    b.Property<string>("Uid");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("UploadImg");
                });

            modelBuilder.Entity("Sport7.CMS.TokenAuthentic.DanganInfer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BankNumber");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("Email");

                    b.Property<string>("EnglishName");

                    b.Property<string>("GongjijinNumber");

                    b.Property<string>("HousePhone");

                    b.Property<string>("Hukou");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<string>("Jiguan");

                    b.Property<string>("JiguanAddress");

                    b.Property<string>("KaihuBank");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Love");

                    b.Property<string>("Married");

                    b.Property<string>("Minzu");

                    b.Property<string>("PeopleJianjie");

                    b.Property<string>("QQ");

                    b.Property<string>("Qudao");

                    b.Property<string>("RecentHouse");

                    b.Property<string>("RecentlyName");

                    b.Property<string>("SeverPeople");

                    b.Property<string>("ShebaoNumber");

                    b.Property<string>("SimpleName");

                    b.Property<string>("Study");

                    b.Property<string>("Telephone");

                    b.Property<string>("TuijianRen");

                    b.Property<string>("WeiXinName");

                    b.Property<string>("Working");

                    b.Property<string>("ZhengzhiMianmao");

                    b.HasKey("Id");

                    b.ToTable("danganInfers");
                });

            modelBuilder.Entity("Sport7.CMS.TokenAuthentic.UserInfer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthdayDate");

                    b.Property<string>("CompanyNumber");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DoworkNumber");

                    b.Property<string>("IDCard");

                    b.Property<string>("IncompanyDate");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Sex");

                    b.Property<string>("StaffNumber");

                    b.Property<string>("Statu");

                    b.Property<string>("TrateDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("userInfers");
                });

            modelBuilder.Entity("Sport7.CMS.TokenAuthentic.UserSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("EmailAddress");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<string>("Izhiwei");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("ManagerMent");

                    b.Property<string>("Password");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.Property<string>("UserName");

                    b.Property<string>("WeexAvtor");

                    b.Property<string>("WeexId");

                    b.Property<string>("WeexNumber");

                    b.Property<string>("WeexUserName");

                    b.HasKey("Id");

                    b.ToTable("UserSession");
                });

            modelBuilder.Entity("Sport7.PermissionManagement.PermissionGrant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey");

                    b.ToTable("Sport7PermissionGrants");
                });

            modelBuilder.Entity("Sport7.SettingManagement.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey");

                    b.ToTable("Sport7Settings");
                });

            modelBuilder.Entity("Sport7.AuditLogging.AuditLogAction", b =>
                {
                    b.HasOne("Sport7.AuditLogging.AuditLog")
                        .WithMany("Actions")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sport7.AuditLogging.EntityChange", b =>
                {
                    b.HasOne("Sport7.AuditLogging.AuditLog")
                        .WithMany("EntityChanges")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sport7.AuditLogging.EntityPropertyChange", b =>
                {
                    b.HasOne("Sport7.AuditLogging.EntityChange")
                        .WithMany("PropertyChanges")
                        .HasForeignKey("EntityChangeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
