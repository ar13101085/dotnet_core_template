using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class PPWDBINIT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BackgroundCheckinProviderListModel",
                columns: table => new
                {
                    BackgroundCheckinProviderListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundCheckinProviderListModel", x => x.BackgroundCheckinProviderListModelId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryListModel",
                columns: table => new
                {
                    CategoryListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryListModel", x => x.CategoryListModelId);
                });

            migrationBuilder.CreateTable(
                name: "CheckInSync",
                columns: table => new
                {
                    CheckInSyncId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Client = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Sent = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckInSync", x => x.CheckInSyncId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyListModel",
                columns: table => new
                {
                    CompanyListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyListModel", x => x.CompanyListModelId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerListModel",
                columns: table => new
                {
                    CustomerListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerListModel", x => x.CustomerListModelId);
                });

            migrationBuilder.CreateTable(
                name: "LineItemDescriptionListModel",
                columns: table => new
                {
                    LineItemDescriptionListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItemDescriptionListModel", x => x.LineItemDescriptionListModelId);
                });

            migrationBuilder.CreateTable(
                name: "MobileCheckin",
                columns: table => new
                {
                    Date = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileCheckin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RecursTypeListModel",
                columns: table => new
                {
                    RecursTypeListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursTypeListModel", x => x.RecursTypeListModelId);
                });

            migrationBuilder.CreateTable(
                name: "RushListModel",
                columns: table => new
                {
                    RushListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RushListModel", x => x.RushListModelId);
                });

            migrationBuilder.CreateTable(
                name: "StateListModel",
                columns: table => new
                {
                    StateListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateListModel", x => x.StateListModelId);
                });

            migrationBuilder.CreateTable(
                name: "SystemOfRecordListModel",
                columns: table => new
                {
                    SystemOfRecordListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemOfRecordListModel", x => x.SystemOfRecordListModelId);
                });

            migrationBuilder.CreateTable(
                name: "TimeZoneListModel",
                columns: table => new
                {
                    TimeZoneListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZoneListModel", x => x.TimeZoneListModelId);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypeListModel",
                columns: table => new
                {
                    WorkTypeListModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypeListModel", x => x.WorkTypeListModelId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    OrderStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReadyForOffice = table.Column<bool>(nullable: false),
                    EstimateCompleteDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    OfficeLocked = table.Column<bool>(nullable: false),
                    FreezeProperty = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.OrderStatusId);
                    table.ForeignKey(
                        name: "FK_OrderStatus_CategoryListModel_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryListModel",
                        principalColumn: "CategoryListModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    SystemOfRecordId = table.Column<int>(nullable: false),
                    IsShowInListContractor = table.Column<bool>(nullable: false),
                    IsShowInListAssignedAdmin = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    IsDisplayAllWorkOrders = table.Column<bool>(nullable: true),
                    IsViewAllWoHistory = table.Column<bool>(nullable: true),
                    DiscountPercentage = table.Column<bool>(nullable: false),
                    TimeZoneListModelId = table.Column<int>(nullable: false),
                    IsSkipOnAutoAssign = table.Column<bool>(nullable: false),
                    LegalFirstName = table.Column<string>(nullable: true),
                    LegalLastName = table.Column<string>(nullable: true),
                    CellPhoneNumber = table.Column<string>(nullable: true),
                    CellPhoneCompany = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StateListModelId = table.Column<int>(nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    IsEmailNotes = table.Column<bool>(nullable: false),
                    IsEmailRemainders = table.Column<bool>(nullable: false),
                    IsEmailNewsWoS = table.Column<bool>(nullable: false),
                    IsEmailUnAssigndWoS = table.Column<bool>(nullable: false),
                    IsEmailFollowUp = table.Column<bool>(nullable: false),
                    IsTextNotes = table.Column<bool>(nullable: false),
                    IsTextRemainders = table.Column<bool>(nullable: false),
                    IsTextNewsWoS = table.Column<bool>(nullable: false),
                    IsTextUnAssigndWoS = table.Column<bool>(nullable: false),
                    IsTextFollowUp = table.Column<bool>(nullable: false),
                    IsEmailReplyToJobNotes = table.Column<bool>(nullable: false),
                    IsReadyForOffice = table.Column<bool>(nullable: false),
                    SentAlertMinutes = table.Column<int>(nullable: false),
                    ContractorScore = table.Column<int>(nullable: false),
                    InsuranceExpire = table.Column<DateTime>(nullable: false),
                    PruvanUserName = table.Column<string>(nullable: true),
                    PruvanPushKey = table.Column<string>(nullable: true),
                    PruvanDateOffset = table.Column<string>(nullable: true),
                    DevicemagicDeviceID = table.Column<string>(nullable: true),
                    AbcHash = table.Column<string>(nullable: true),
                    ServiceLinkId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_StateListModel_StateListModelId",
                        column: x => x.StateListModelId,
                        principalTable: "StateListModel",
                        principalColumn: "StateListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_SystemOfRecordListModel_SystemOfRecordId",
                        column: x => x.SystemOfRecordId,
                        principalTable: "SystemOfRecordListModel",
                        principalColumn: "SystemOfRecordListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_TimeZoneListModel_TimeZoneListModelId",
                        column: x => x.TimeZoneListModelId,
                        principalTable: "TimeZoneListModel",
                        principalColumn: "TimeZoneListModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderAccessHistory",
                columns: table => new
                {
                    OrderAccessHistoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAccessHistory", x => x.OrderAccessHistoryId);
                    table.ForeignKey(
                        name: "FK_OrderAccessHistory_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubContractCompanies",
                columns: table => new
                {
                    SubContractCompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubContractorCompanyCompanyListModelId = table.Column<int>(nullable: true),
                    IsViewAllWoS = table.Column<bool>(nullable: true),
                    AssignNewOrders = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractCompanies", x => x.SubContractCompanyId);
                    table.ForeignKey(
                        name: "FK_SubContractCompanies_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubContractCompanies_CompanyListModel_SubContractorCompanyCompanyListModelId",
                        column: x => x.SubContractorCompanyCompanyListModelId,
                        principalTable: "CompanyListModel",
                        principalColumn: "CompanyListModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    WorkOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkOrderNumber = table.Column<string>(nullable: true),
                    PPW = table.Column<int>(nullable: false),
                    WorkTypeListModelId = table.Column<int>(nullable: false),
                    CategoryListModelId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    LoanNumber = table.Column<int>(nullable: false),
                    LoanType = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StateListModelId = table.Column<int>(nullable: false),
                    ZipCode = table.Column<int>(nullable: false),
                    ContractorId = table.Column<string>(nullable: true),
                    AdminId = table.Column<string>(nullable: true),
                    IsReadyForField = table.Column<bool>(nullable: false),
                    RushListModelId = table.Column<int>(nullable: false),
                    IsBATF = table.Column<bool>(nullable: false),
                    LotSize = table.Column<string>(nullable: true),
                    LockCode = table.Column<string>(nullable: true),
                    Mortgager = table.Column<string>(nullable: true),
                    KeyCode = table.Column<string>(nullable: true),
                    BackgroundCheckinProviderListModelId = table.Column<int>(nullable: false),
                    LockLocation = table.Column<string>(nullable: true),
                    GateCode = table.Column<string>(nullable: true),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    ClientDueDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    IsInspection = table.Column<bool>(nullable: false),
                    BrokerName = table.Column<string>(nullable: true),
                    BrokerCompany = table.Column<string>(nullable: true),
                    BrokerPhone = table.Column<string>(nullable: true),
                    BrokerEmail = table.Column<string>(nullable: true),
                    CancelDate = table.Column<DateTime>(nullable: false),
                    IsMissingInfo = table.Column<bool>(nullable: false),
                    IsNeedsReviewedAsap = table.Column<bool>(nullable: false),
                    MissingInfoComment = table.Column<string>(nullable: true),
                    OrderStatusId = table.Column<int>(nullable: true),
                    CompanyListModelId = table.Column<int>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    ClientPhone = table.Column<string>(nullable: true),
                    ClientEmail = table.Column<string>(nullable: true),
                    IsRecurring = table.Column<bool>(nullable: false),
                    RecursEvery = table.Column<int>(nullable: false),
                    RecursTypeListModelId = table.Column<int>(nullable: false),
                    RecursCutOffDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.WorkOrderId);
                    table.ForeignKey(
                        name: "FK_WorkOrders_AspNetUsers_AdminId",
                        column: x => x.AdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrders_BackgroundCheckinProviderListModel_BackgroundCheckinProviderListModelId",
                        column: x => x.BackgroundCheckinProviderListModelId,
                        principalTable: "BackgroundCheckinProviderListModel",
                        principalColumn: "BackgroundCheckinProviderListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrders_CategoryListModel_CategoryListModelId",
                        column: x => x.CategoryListModelId,
                        principalTable: "CategoryListModel",
                        principalColumn: "CategoryListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrders_CompanyListModel_CompanyListModelId",
                        column: x => x.CompanyListModelId,
                        principalTable: "CompanyListModel",
                        principalColumn: "CompanyListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrders_AspNetUsers_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "OrderStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrders_RecursTypeListModel_RecursTypeListModelId",
                        column: x => x.RecursTypeListModelId,
                        principalTable: "RecursTypeListModel",
                        principalColumn: "RecursTypeListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrders_RushListModel_RushListModelId",
                        column: x => x.RushListModelId,
                        principalTable: "RushListModel",
                        principalColumn: "RushListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrders_StateListModel_StateListModelId",
                        column: x => x.StateListModelId,
                        principalTable: "StateListModel",
                        principalColumn: "StateListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOrders_WorkTypeListModel_WorkTypeListModelId",
                        column: x => x.WorkTypeListModelId,
                        principalTable: "WorkTypeListModel",
                        principalColumn: "WorkTypeListModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessHistories",
                columns: table => new
                {
                    AccessHistoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    WorkOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessHistories", x => x.AccessHistoryId);
                    table.ForeignKey(
                        name: "FK_AccessHistories_WorkOrders_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrders",
                        principalColumn: "WorkOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LineItem",
                columns: table => new
                {
                    LineItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LineItemDescriptionListModelId = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    AdditionalInstruction = table.Column<string>(nullable: true),
                    WorkOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItem", x => x.LineItemId);
                    table.ForeignKey(
                        name: "FK_LineItem_LineItemDescriptionListModel_LineItemDescriptionListModelId",
                        column: x => x.LineItemDescriptionListModelId,
                        principalTable: "LineItemDescriptionListModel",
                        principalColumn: "LineItemDescriptionListModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LineItem_WorkOrders_WorkOrderId",
                        column: x => x.WorkOrderId,
                        principalTable: "WorkOrders",
                        principalColumn: "WorkOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BackgroundCheckinProviderListModel",
                columns: new[] { "BackgroundCheckinProviderListModelId", "Value" },
                values: new object[,]
                {
                    { 1, "Aspen Grove Solutions" },
                    { 2, "ServiceLink" }
                });

            migrationBuilder.InsertData(
                table: "CategoryListModel",
                columns: new[] { "CategoryListModelId", "Value" },
                values: new object[,]
                {
                    { 1, "10K+ Bid Check" },
                    { 2, "3rd Party" },
                    { 3, "Dummy, Do not Assign" },
                    { 4, "Fred Williams" },
                    { 5, "Ready to Assign" },
                    { 6, "Reassignment Needed" },
                    { 7, "RTV" },
                    { 8, "RUSH" },
                    { 9, "RUSH RTV" }
                });

            migrationBuilder.InsertData(
                table: "CompanyListModel",
                columns: new[] { "CompanyListModelId", "Value" },
                values: new object[,]
                {
                    { 9, "1910" },
                    { 8, "191" },
                    { 7, "125" },
                    { 6, "124" },
                    { 1, "000" },
                    { 4, "1213" },
                    { 3, "1212" },
                    { 2, "121" },
                    { 5, "122" }
                });

            migrationBuilder.InsertData(
                table: "CustomerListModel",
                columns: new[] { "CustomerListModelId", "Value" },
                values: new object[,]
                {
                    { 6, "455" },
                    { 8, "659" },
                    { 7, "518" },
                    { 5, "357" },
                    { 9, "Bank of America" },
                    { 3, "335FC Caliber Home Loans" },
                    { 2, "328" },
                    { 1, "258" },
                    { 4, "335GC Caliber Home Loan" }
                });

            migrationBuilder.InsertData(
                table: "LineItemDescriptionListModel",
                columns: new[] { "LineItemDescriptionListModelId", "Value" },
                values: new object[,]
                {
                    { 9, "Basement Pumping, Over 1000SF Up to 1' Deep" },
                    { 8, "Basement Pumping, Up To 1000SF Up to 2' Deep" },
                    { 7, "Antimicrobial Treatment (walls, ceilings, )" },
                    { 5, "Animal Removal - (Small, med. large)" },
                    { 6, "Antimicrobial Treatment (open beams, subfloors)" },
                    { 3, "Additional Lockset - After Main Door Secure" },
                    { 2, "Rush Fee" },
                    { 1, "Lock Set" },
                    { 4, "Additional Lock / Dead Bolt-After Main Door Secure" }
                });

            migrationBuilder.InsertData(
                table: "RushListModel",
                columns: new[] { "RushListModelId", "Value" },
                values: new object[,]
                {
                    { 1, "RUSH" },
                    { 2, "RVM's RUSH" }
                });

            migrationBuilder.InsertData(
                table: "StateListModel",
                columns: new[] { "StateListModelId", "Value" },
                values: new object[,]
                {
                    { 7, "CT" },
                    { 8, "DC" },
                    { 9, "DE" },
                    { 6, "CO" },
                    { 2, "AL" },
                    { 4, "AZ" },
                    { 3, "AR" },
                    { 1, "AK" },
                    { 5, "CA" }
                });

            migrationBuilder.InsertData(
                table: "WorkTypeListModel",
                columns: new[] { "WorkTypeListModelId", "Value" },
                values: new object[,]
                {
                    { 8, "Continuing REO Service" },
                    { 1, "Additional Bid" },
                    { 2, "Bid Approval" },
                    { 3, "Bid Request" },
                    { 4, "Bid Request Dual Control" },
                    { 5, "Bypass Repairs" },
                    { 6, "Cash 4 Keys" },
                    { 7, "Clear Boarding" },
                    { 9, "Conveyance Condition" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessHistories_WorkOrderId",
                table: "AccessHistories",
                column: "WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StateListModelId",
                table: "AspNetUsers",
                column: "StateListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SystemOfRecordId",
                table: "AspNetUsers",
                column: "SystemOfRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TimeZoneListModelId",
                table: "AspNetUsers",
                column: "TimeZoneListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_LineItemDescriptionListModelId",
                table: "LineItem",
                column: "LineItemDescriptionListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItem_WorkOrderId",
                table: "LineItem",
                column: "WorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderAccessHistory_UserId",
                table: "OrderAccessHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_CategoryId",
                table: "OrderStatus",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractCompanies_ApplicationUserId",
                table: "SubContractCompanies",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractCompanies_SubContractorCompanyCompanyListModelId",
                table: "SubContractCompanies",
                column: "SubContractorCompanyCompanyListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_AdminId",
                table: "WorkOrders",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_BackgroundCheckinProviderListModelId",
                table: "WorkOrders",
                column: "BackgroundCheckinProviderListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_CategoryListModelId",
                table: "WorkOrders",
                column: "CategoryListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_CompanyListModelId",
                table: "WorkOrders",
                column: "CompanyListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_ContractorId",
                table: "WorkOrders",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_OrderStatusId",
                table: "WorkOrders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_RecursTypeListModelId",
                table: "WorkOrders",
                column: "RecursTypeListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_RushListModelId",
                table: "WorkOrders",
                column: "RushListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_StateListModelId",
                table: "WorkOrders",
                column: "StateListModelId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_WorkTypeListModelId",
                table: "WorkOrders",
                column: "WorkTypeListModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessHistories");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CheckInSync");

            migrationBuilder.DropTable(
                name: "CustomerListModel");

            migrationBuilder.DropTable(
                name: "LineItem");

            migrationBuilder.DropTable(
                name: "MobileCheckin");

            migrationBuilder.DropTable(
                name: "OrderAccessHistory");

            migrationBuilder.DropTable(
                name: "SubContractCompanies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "LineItemDescriptionListModel");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BackgroundCheckinProviderListModel");

            migrationBuilder.DropTable(
                name: "CompanyListModel");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "RecursTypeListModel");

            migrationBuilder.DropTable(
                name: "RushListModel");

            migrationBuilder.DropTable(
                name: "WorkTypeListModel");

            migrationBuilder.DropTable(
                name: "StateListModel");

            migrationBuilder.DropTable(
                name: "SystemOfRecordListModel");

            migrationBuilder.DropTable(
                name: "TimeZoneListModel");

            migrationBuilder.DropTable(
                name: "CategoryListModel");
        }
    }
}
