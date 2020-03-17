using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport7.CMS.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    ImageList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    XiangmuTag = table.Column<string>(nullable: true),
                    SaleCondtion = table.Column<string>(nullable: true),
                    OpenningTime = table.Column<DateTime>(nullable: false),
                    FinishHouse = table.Column<string>(nullable: true),
                    Huanxian = table.Column<string>(nullable: true),
                    LoupanAddress = table.Column<string>(nullable: true),
                    SeePrice = table.Column<string>(nullable: true),
                    Sale = table.Column<string>(nullable: true),
                    LowPrice = table.Column<string>(nullable: true),
                    SaleHuxing = table.Column<string>(nullable: true),
                    ShoulouAddress = table.Column<string>(nullable: true),
                    BuildType = table.Column<string>(nullable: true),
                    ChanquanNian = table.Column<string>(nullable: true),
                    Zhuangxiu = table.Column<string>(nullable: true),
                    KaifaShop = table.Column<string>(nullable: true),
                    TouziShop = table.Column<string>(nullable: true),
                    Rongjilv = table.Column<string>(nullable: true),
                    Lvhualv = table.Column<string>(nullable: true),
                    GuihuaUser = table.Column<string>(nullable: true),
                    LoucengCondition = table.Column<string>(nullable: true),
                    HasArea = table.Column<string>(nullable: true),
                    JianzhuArea = table.Column<string>(nullable: true),
                    GongchengProgress = table.Column<string>(nullable: true),
                    WuyeFee = table.Column<string>(nullable: true),
                    WuyeCompany = table.Column<string>(nullable: true),
                    CarNumber = table.Column<string>(nullable: true),
                    ParkingRadio = table.Column<string>(nullable: true),
                    CarUpNumber = table.Column<string>(nullable: true),
                    NumberUndergroundCar = table.Column<string>(nullable: true),
                    HouseInferId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseInfer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    FloorName = table.Column<string>(nullable: true),
                    AllVideo = table.Column<string>(nullable: true),
                    Video = table.Column<string>(nullable: true),
                    ImgHeader = table.Column<string>(nullable: true),
                    ImgList = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    FloorPrice = table.Column<string>(nullable: true),
                    OpeningTime = table.Column<DateTime>(nullable: false),
                    Apartment = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Onfoot = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ApartMentImgList = table.Column<string>(nullable: true),
                    ShapanImgList = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseInfer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "presalePermits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    HouseInferId = table.Column<Guid>(nullable: false),
                    PreSaleCard = table.Column<string>(nullable: true),
                    IssuingTime = table.Column<string>(nullable: true),
                    BindBuilding = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presalePermits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport7AuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    ApplicationName = table.Column<string>(maxLength: 96, nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    TenantName = table.Column<string>(nullable: true),
                    ImpersonatorUserId = table.Column<Guid>(nullable: true),
                    ImpersonatorTenantId = table.Column<Guid>(nullable: true),
                    ExecutionTime = table.Column<DateTime>(nullable: false),
                    ExecutionDuration = table.Column<int>(nullable: false),
                    ClientIpAddress = table.Column<string>(maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(maxLength: 128, nullable: true),
                    ClientId = table.Column<string>(maxLength: 64, nullable: true),
                    CorrelationId = table.Column<string>(maxLength: 64, nullable: true),
                    BrowserInfo = table.Column<string>(maxLength: 512, nullable: true),
                    HttpMethod = table.Column<string>(maxLength: 16, nullable: true),
                    Url = table.Column<string>(maxLength: 256, nullable: true),
                    Exceptions = table.Column<string>(maxLength: 4000, nullable: true),
                    Comments = table.Column<string>(maxLength: 256, nullable: true),
                    HttpStatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport7AuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport7PermissionGrants",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderName = table.Column<string>(maxLength: 64, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport7PermissionGrants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport7Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(maxLength: 2048, nullable: false),
                    ProviderName = table.Column<string>(maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport7Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sport7AuditLogActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true),
                    AuditLogId = table.Column<Guid>(nullable: false),
                    ServiceName = table.Column<string>(maxLength: 256, nullable: true),
                    MethodName = table.Column<string>(maxLength: 128, nullable: true),
                    Parameters = table.Column<string>(maxLength: 2000, nullable: true),
                    ExecutionTime = table.Column<DateTime>(nullable: false),
                    ExecutionDuration = table.Column<int>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport7AuditLogActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sport7AuditLogActions_Sport7AuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "Sport7AuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sport7EntityChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AuditLogId = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true),
                    ChangeTime = table.Column<DateTime>(nullable: false),
                    ChangeType = table.Column<byte>(nullable: false),
                    EntityTenantId = table.Column<Guid>(nullable: true),
                    EntityId = table.Column<string>(maxLength: 128, nullable: false),
                    EntityTypeFullName = table.Column<string>(maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport7EntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sport7EntityChanges_Sport7AuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "Sport7AuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sport7EntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true),
                    EntityChangeId = table.Column<Guid>(nullable: false),
                    NewValue = table.Column<string>(maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(maxLength: 128, nullable: false),
                    PropertyTypeFullName = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport7EntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sport7EntityPropertyChanges_Sport7EntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "Sport7EntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sport7AuditLogActions_AuditLogId",
                table: "Sport7AuditLogActions",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_Sport7AuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime",
                table: "Sport7AuditLogActions",
                columns: new[] { "TenantId", "ServiceName", "MethodName", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_Sport7AuditLogs_TenantId_ExecutionTime",
                table: "Sport7AuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_Sport7AuditLogs_TenantId_UserId_ExecutionTime",
                table: "Sport7AuditLogs",
                columns: new[] { "TenantId", "UserId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_Sport7EntityChanges_AuditLogId",
                table: "Sport7EntityChanges",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_Sport7EntityChanges_TenantId_EntityTypeFullName_EntityId",
                table: "Sport7EntityChanges",
                columns: new[] { "TenantId", "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_Sport7EntityPropertyChanges_EntityChangeId",
                table: "Sport7EntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sport7PermissionGrants_Name_ProviderName_ProviderKey",
                table: "Sport7PermissionGrants",
                columns: new[] { "Name", "ProviderName", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_Sport7Settings_Name_ProviderName_ProviderKey",
                table: "Sport7Settings",
                columns: new[] { "Name", "ProviderName", "ProviderKey" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "HouseDetail");

            migrationBuilder.DropTable(
                name: "HouseInfer");

            migrationBuilder.DropTable(
                name: "presalePermits");

            migrationBuilder.DropTable(
                name: "Sport7AuditLogActions");

            migrationBuilder.DropTable(
                name: "Sport7EntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "Sport7PermissionGrants");

            migrationBuilder.DropTable(
                name: "Sport7Settings");

            migrationBuilder.DropTable(
                name: "Sport7EntityChanges");

            migrationBuilder.DropTable(
                name: "Sport7AuditLogs");
        }
    }
}
