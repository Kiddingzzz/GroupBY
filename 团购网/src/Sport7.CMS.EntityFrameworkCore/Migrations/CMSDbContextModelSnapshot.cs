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

            modelBuilder.Entity("Sport7.CMS.Feedbacks.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contact");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("ImageList");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<int>("Score");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Sport7.CMS.House.HouseDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuildType");

                    b.Property<string>("CarNumber");

                    b.Property<string>("CarUpNumber");

                    b.Property<string>("ChanquanNian");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("FinishHouse");

                    b.Property<string>("GongchengProgress");

                    b.Property<string>("GuihuaUser");

                    b.Property<string>("HasArea");

                    b.Property<Guid>("HouseInferId");

                    b.Property<string>("Huanxian");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<string>("JianzhuArea");

                    b.Property<string>("KaifaShop");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("LoucengCondition");

                    b.Property<string>("LoupanAddress");

                    b.Property<string>("LowPrice");

                    b.Property<string>("Lvhualv");

                    b.Property<string>("NumberUndergroundCar");

                    b.Property<DateTime>("OpenningTime");

                    b.Property<string>("ParkingRadio");

                    b.Property<string>("Rongjilv");

                    b.Property<string>("Sale");

                    b.Property<string>("SaleCondtion");

                    b.Property<string>("SaleHuxing");

                    b.Property<string>("SeePrice");

                    b.Property<string>("ShoulouAddress");

                    b.Property<string>("TouziShop");

                    b.Property<string>("WuyeCompany");

                    b.Property<string>("WuyeFee");

                    b.Property<string>("XiangmuTag");

                    b.Property<string>("Zhuangxiu");

                    b.HasKey("Id");

                    b.ToTable("HouseDetail");
                });

            modelBuilder.Entity("Sport7.CMS.House.HouseInfer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Alias");

                    b.Property<string>("AllVideo");

                    b.Property<string>("ApartMentImgList");

                    b.Property<string>("Apartment");

                    b.Property<string>("Area");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("FloorName");

                    b.Property<string>("FloorPrice");

                    b.Property<string>("HuxingImg");

                    b.Property<string>("ImgHeader");

                    b.Property<string>("ImgList");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Onfoot");

                    b.Property<DateTime>("OpeningTime");

                    b.Property<string>("Peitaotu");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("ShapanImgList");

                    b.Property<string>("Shijingtu");

                    b.Property<string>("Shoulouchu");

                    b.Property<string>("Tags");

                    b.Property<string>("VTImg");

                    b.Property<string>("Video");

                    b.Property<string>("Zhengzhao");

                    b.HasKey("Id");

                    b.ToTable("HouseInfer");
                });

            modelBuilder.Entity("Sport7.CMS.House.PresalePermit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BindBuilding");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<Guid>("HouseInferId");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<string>("IssuingTime");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("PreSaleCard");

                    b.HasKey("Id");

                    b.ToTable("presalePermits");
                });

            modelBuilder.Entity("Sport7.CMS.News.HouseNews", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abstract");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("GenereMange");

                    b.Property<string>("HeaderImg");

                    b.Property<string>("HouseTitle");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<DateTime>("PulishTime");

                    b.HasKey("Id");

                    b.ToTable("HouseNews");
                });

            modelBuilder.Entity("Sport7.CMS.Receadress.ReceAdress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime");

                    b.Property<string>("DetAdress");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("RecePeople");

                    b.Property<string>("ReceTel");

                    b.Property<Guid>("Userid");

                    b.Property<bool>("defaultAdress");

                    b.HasKey("Id");

                    b.ToTable("ReceAdress");
                });

            modelBuilder.Entity("Sport7.CMS.houseOrder.HouseOrder", b =>
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

                    b.Property<string>("HousePrice");

                    b.Property<bool>("HouseType");

                    b.Property<Guid>("Houseid");

                    b.Property<string>("ImgHeard");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId");

                    b.Property<Guid>("UserId");

                    b.Property<string>("houseTitle");

                    b.HasKey("Id");

                    b.ToTable("HouseOrder");
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
