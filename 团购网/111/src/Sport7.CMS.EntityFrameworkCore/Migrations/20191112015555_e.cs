using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sport7.CMS.Migrations
{
    public partial class e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    PostId = table.Column<Guid>(nullable: false),
                    RepliedCommentId = table.Column<Guid>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "danganInfers",
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
                    Jiguan = table.Column<string>(nullable: true),
                    EnglishName = table.Column<string>(nullable: true),
                    RecentlyName = table.Column<string>(nullable: true),
                    SimpleName = table.Column<string>(nullable: true),
                    WeiXinName = table.Column<string>(nullable: true),
                    QQ = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HousePhone = table.Column<string>(nullable: true),
                    Married = table.Column<string>(nullable: true),
                    Minzu = table.Column<string>(nullable: true),
                    SeverPeople = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Study = table.Column<string>(nullable: true),
                    Working = table.Column<string>(nullable: true),
                    JiguanAddress = table.Column<string>(nullable: true),
                    Hukou = table.Column<string>(nullable: true),
                    ZhengzhiMianmao = table.Column<string>(nullable: true),
                    RecentHouse = table.Column<string>(nullable: true),
                    ShebaoNumber = table.Column<string>(nullable: true),
                    GongjijinNumber = table.Column<string>(nullable: true),
                    KaihuBank = table.Column<string>(nullable: true),
                    BankNumber = table.Column<string>(nullable: true),
                    PeopleJianjie = table.Column<string>(nullable: true),
                    Love = table.Column<string>(nullable: true),
                    TuijianRen = table.Column<string>(nullable: true),
                    Qudao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danganInfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeDictionary",
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
                    DictionaryName = table.Column<string>(nullable: true),
                    BuildingNumber = table.Column<string>(nullable: true),
                    Unit = table.Column<int>(nullable: false),
                    NumberLayer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeDictionary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeDong",
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
                    BuildingNumber = table.Column<string>(nullable: true),
                    HomeDictinaryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeDong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeLayers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeLayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeList",
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
                    Housecode = table.Column<string>(nullable: true),
                    BuildName = table.Column<string>(nullable: true),
                    BuildUnit = table.Column<string>(nullable: true),
                    BuildNumber = table.Column<string>(nullable: true),
                    BuildFoolr = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    BuildArea = table.Column<int>(nullable: false),
                    Fang = table.Column<string>(nullable: true),
                    Ting = table.Column<string>(nullable: true),
                    Wei = table.Column<string>(nullable: true),
                    Chufang = table.Column<string>(nullable: true),
                    Yangtai = table.Column<string>(nullable: true),
                    Renovation = table.Column<string>(nullable: true),
                    CoverArea = table.Column<int>(nullable: false),
                    Orientation = table.Column<string>(nullable: true),
                    Elevator = table.Column<string>(nullable: true),
                    BrightSpot = table.Column<string>(nullable: true),
                    Affiliated = table.Column<string>(nullable: true),
                    AffiliatedArea = table.Column<int>(nullable: false),
                    PropertyFee = table.Column<string>(nullable: true),
                    HouseStructure = table.Column<string>(nullable: true),
                    HouseStatu = table.Column<string>(nullable: true),
                    Pianqu = table.Column<string>(nullable: true),
                    JXWPerson = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeNoUnit",
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
                    HomeDictinaryId = table.Column<Guid>(nullable: false),
                    NumberLayer = table.Column<int>(nullable: false),
                    IsUnit = table.Column<bool>(nullable: false),
                    HomeDongId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeNoUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeUnit",
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
                    Unit = table.Column<int>(nullable: false),
                    HomeDictinaryId = table.Column<Guid>(nullable: false),
                    NumberLayer = table.Column<int>(nullable: false),
                    IsUnit = table.Column<bool>(nullable: false),
                    HomeDongId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeUnit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseInformation",
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
                    Price = table.Column<int>(nullable: false),
                    FloorPrice = table.Column<int>(nullable: false),
                    Paymethod = table.Column<string>(nullable: true),
                    SaleStatu = table.Column<string>(nullable: true),
                    CenterPrice = table.Column<int>(nullable: false),
                    LoginName = table.Column<string>(nullable: true),
                    years = table.Column<string>(nullable: true),
                    chanquan = table.Column<string>(nullable: true),
                    DiyaStatu = table.Column<string>(nullable: true),
                    Reprice = table.Column<string>(nullable: true),
                    Buydate = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    LookWay = table.Column<string>(nullable: true),
                    HouseStay = table.Column<string>(nullable: true),
                    RecentMoney = table.Column<int>(nullable: false),
                    MonthRecentMoney = table.Column<int>(nullable: false),
                    GetName = table.Column<string>(nullable: true),
                    KeyCode = table.Column<string>(nullable: true),
                    HouseID = table.Column<string>(nullable: true),
                    getHomer = table.Column<string>(nullable: true),
                    HomeListId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OwnerInfor",
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
                    OwnerName = table.Column<string>(nullable: true),
                    phoneNumber1 = table.Column<string>(nullable: true),
                    phoneNumber2 = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    IentityCard = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    HomeListId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerInfor", x => x.Id);
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
                name: "UpdateHouse",
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
                    Comment = table.Column<string>(nullable: true),
                    CommentTime = table.Column<DateTime>(nullable: false),
                    UpdatePerson = table.Column<Guid>(nullable: false),
                    HomeListId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UploadImg",
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
                    Url = table.Column<string>(nullable: true),
                    Uid = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    HouseId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadImg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userInfers",
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
                    Name = table.Column<string>(nullable: true),
                    StaffNumber = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    DoworkNumber = table.Column<string>(nullable: true),
                    CompanyNumber = table.Column<string>(nullable: true),
                    IDCard = table.Column<string>(nullable: true),
                    BirthdayDate = table.Column<string>(nullable: true),
                    IncompanyDate = table.Column<string>(nullable: true),
                    Statu = table.Column<string>(nullable: true),
                    TrateDate = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSession",
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
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    WeexId = table.Column<string>(nullable: true),
                    WeexAvtor = table.Column<string>(nullable: true),
                    WeexUserName = table.Column<string>(nullable: true),
                    WeexNumber = table.Column<string>(nullable: true),
                    ManagerMent = table.Column<string>(nullable: true),
                    Izhiwei = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSession", x => x.Id);
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "danganInfers");

            migrationBuilder.DropTable(
                name: "HomeDictionary");

            migrationBuilder.DropTable(
                name: "HomeDong");

            migrationBuilder.DropTable(
                name: "HomeLayers");

            migrationBuilder.DropTable(
                name: "HomeList");

            migrationBuilder.DropTable(
                name: "HomeNoUnit");

            migrationBuilder.DropTable(
                name: "HomeUnit");

            migrationBuilder.DropTable(
                name: "HouseInformation");

            migrationBuilder.DropTable(
                name: "OwnerInfor");

            migrationBuilder.DropTable(
                name: "Sport7AuditLogActions");

            migrationBuilder.DropTable(
                name: "Sport7EntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "Sport7PermissionGrants");

            migrationBuilder.DropTable(
                name: "Sport7Settings");

            migrationBuilder.DropTable(
                name: "UpdateHouse");

            migrationBuilder.DropTable(
                name: "UploadImg");

            migrationBuilder.DropTable(
                name: "userInfers");

            migrationBuilder.DropTable(
                name: "UserSession");

            migrationBuilder.DropTable(
                name: "Sport7EntityChanges");

            migrationBuilder.DropTable(
                name: "Sport7AuditLogs");
        }
    }
}
