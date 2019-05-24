﻿// <auto-generated />
using System;
using KitcPPW.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KitcPPW.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190416085906_Order Status Category remove")]
    partial class OrderStatusCategoryremove
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KitcPPW.Models.AccessHistory", b =>
                {
                    b.Property<long>("AccessHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<DateTime>("Date");

                    b.Property<string>("User");

                    b.Property<int?>("WorkOrderId");

                    b.HasKey("AccessHistoryId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("AccessHistories");
                });

            modelBuilder.Entity("KitcPPW.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("KitcPPW.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbcHash");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("AssignGroupRoleId");

                    b.Property<string>("CellPhoneCompany");

                    b.Property<string>("CellPhoneNumber");

                    b.Property<string>("City");

                    b.Property<string>("Comments");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("ContractorScore");

                    b.Property<string>("DevicemagicDeviceID");

                    b.Property<bool>("DiscountPercentage");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("InsuranceExpire");

                    b.Property<bool?>("IsActive");

                    b.Property<bool?>("IsDisplayAllWorkOrders");

                    b.Property<bool>("IsEmailFollowUp");

                    b.Property<bool>("IsEmailNewsWoS");

                    b.Property<bool>("IsEmailNotes");

                    b.Property<bool>("IsEmailRemainders");

                    b.Property<bool>("IsEmailReplyToJobNotes");

                    b.Property<bool>("IsEmailUnAssigndWoS");

                    b.Property<bool>("IsReadyForOffice");

                    b.Property<bool>("IsShowInListAssignedAdmin");

                    b.Property<bool>("IsShowInListContractor");

                    b.Property<bool>("IsSkipOnAutoAssign");

                    b.Property<bool>("IsTextFollowUp");

                    b.Property<bool>("IsTextNewsWoS");

                    b.Property<bool>("IsTextNotes");

                    b.Property<bool>("IsTextRemainders");

                    b.Property<bool>("IsTextUnAssigndWoS");

                    b.Property<bool?>("IsViewAllWoHistory");

                    b.Property<string>("LastName");

                    b.Property<string>("LegalFirstName");

                    b.Property<string>("LegalLastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PruvanDateOffset");

                    b.Property<string>("PruvanPushKey");

                    b.Property<string>("PruvanUserName");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("SentAlertMinutes");

                    b.Property<string>("ServiceLinkId");

                    b.Property<int>("StateListModelId");

                    b.Property<int>("SystemOfRecordId");

                    b.Property<int>("TimeZoneListModelId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("StateListModelId");

                    b.HasIndex("SystemOfRecordId");

                    b.HasIndex("TimeZoneListModelId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("KitcPPW.Models.BackgroundCheckinProviderListModel", b =>
                {
                    b.Property<int>("BackgroundCheckinProviderListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("BackgroundCheckinProviderListModelId");

                    b.ToTable("BackgroundCheckinProviderListModel");

                    b.HasData(
                        new { BackgroundCheckinProviderListModelId = 1, Value = "Aspen Grove Solutions" },
                        new { BackgroundCheckinProviderListModelId = 2, Value = "ServiceLink" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.CategoryListModel", b =>
                {
                    b.Property<int>("CategoryListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("CategoryListModelId");

                    b.ToTable("CategoryListModel");

                    b.HasData(
                        new { CategoryListModelId = 1, Value = "10K+ Bid Check" },
                        new { CategoryListModelId = 2, Value = "3rd Party" },
                        new { CategoryListModelId = 3, Value = "Dummy, Do not Assign" },
                        new { CategoryListModelId = 4, Value = "Fred Williams" },
                        new { CategoryListModelId = 5, Value = "Ready to Assign" },
                        new { CategoryListModelId = 6, Value = "Reassignment Needed" },
                        new { CategoryListModelId = 7, Value = "RTV" },
                        new { CategoryListModelId = 8, Value = "RUSH" },
                        new { CategoryListModelId = 9, Value = "RUSH RTV" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.CheckInSync", b =>
                {
                    b.Property<int>("CheckInSyncId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Sent");

                    b.Property<string>("Status");

                    b.HasKey("CheckInSyncId");

                    b.ToTable("CheckInSync");
                });

            modelBuilder.Entity("KitcPPW.Models.CompanyListModel", b =>
                {
                    b.Property<int>("CompanyListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("CompanyListModelId");

                    b.ToTable("CompanyListModel");

                    b.HasData(
                        new { CompanyListModelId = 1, Value = "000" },
                        new { CompanyListModelId = 2, Value = "121" },
                        new { CompanyListModelId = 3, Value = "1212" },
                        new { CompanyListModelId = 4, Value = "1213" },
                        new { CompanyListModelId = 5, Value = "122" },
                        new { CompanyListModelId = 6, Value = "124" },
                        new { CompanyListModelId = 7, Value = "125" },
                        new { CompanyListModelId = 8, Value = "191" },
                        new { CompanyListModelId = 9, Value = "1910" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.CustomerListModel", b =>
                {
                    b.Property<int>("CustomerListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("CustomerListModelId");

                    b.ToTable("CustomerListModel");

                    b.HasData(
                        new { CustomerListModelId = 1, Value = "258" },
                        new { CustomerListModelId = 2, Value = "328" },
                        new { CustomerListModelId = 3, Value = "335FC Caliber Home Loans" },
                        new { CustomerListModelId = 4, Value = "335GC Caliber Home Loan" },
                        new { CustomerListModelId = 5, Value = "357" },
                        new { CustomerListModelId = 6, Value = "455" },
                        new { CustomerListModelId = 7, Value = "518" },
                        new { CustomerListModelId = 8, Value = "659" },
                        new { CustomerListModelId = 9, Value = "Bank of America" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.LineItem", b =>
                {
                    b.Property<int>("LineItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInstruction");

                    b.Property<int>("LineItemDescriptionListModelId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Qty");

                    b.Property<decimal>("Total");

                    b.Property<int?>("WorkOrderId");

                    b.HasKey("LineItemId");

                    b.HasIndex("LineItemDescriptionListModelId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("KitcPPW.Models.LineItemDescriptionListModel", b =>
                {
                    b.Property<int>("LineItemDescriptionListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("LineItemDescriptionListModelId");

                    b.ToTable("LineItemDescriptionListModel");

                    b.HasData(
                        new { LineItemDescriptionListModelId = 1, Value = "Lock Set" },
                        new { LineItemDescriptionListModelId = 2, Value = "Rush Fee" },
                        new { LineItemDescriptionListModelId = 3, Value = "Additional Lockset - After Main Door Secure" },
                        new { LineItemDescriptionListModelId = 4, Value = "Additional Lock / Dead Bolt-After Main Door Secure" },
                        new { LineItemDescriptionListModelId = 5, Value = "Animal Removal - (Small, med. large)" },
                        new { LineItemDescriptionListModelId = 6, Value = "Antimicrobial Treatment (open beams, subfloors)" },
                        new { LineItemDescriptionListModelId = 7, Value = "Antimicrobial Treatment (walls, ceilings, )" },
                        new { LineItemDescriptionListModelId = 8, Value = "Basement Pumping, Up To 1000SF Up to 2' Deep" },
                        new { LineItemDescriptionListModelId = 9, Value = "Basement Pumping, Over 1000SF Up to 1' Deep" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.MobileCheckin", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.ToTable("MobileCheckin");
                });

            modelBuilder.Entity("KitcPPW.Models.OrderAccessHistory", b =>
                {
                    b.Property<long>("OrderAccessHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("OrderAccessHistoryId");

                    b.HasIndex("UserId");

                    b.ToTable("OrderAccessHistory");
                });

            modelBuilder.Entity("KitcPPW.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EstimateCompleteDate");

                    b.Property<bool>("FreezeProperty");

                    b.Property<bool>("OfficeLocked");

                    b.Property<bool>("ReadyForOffice");

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("KitcPPW.Models.RecursTypeListModel", b =>
                {
                    b.Property<int>("RecursTypeListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("RecursTypeListModelId");

                    b.ToTable("RecursTypeListModel");

                    b.HasData(
                        new { RecursTypeListModelId = 1, Value = "Day(s)" },
                        new { RecursTypeListModelId = 2, Value = "Week(s)" },
                        new { RecursTypeListModelId = 3, Value = "Month(s)" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.RushListModel", b =>
                {
                    b.Property<int>("RushListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("RushListModelId");

                    b.ToTable("RushListModel");

                    b.HasData(
                        new { RushListModelId = 1, Value = "RUSH" },
                        new { RushListModelId = 2, Value = "RVM's RUSH" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.StateListModel", b =>
                {
                    b.Property<int>("StateListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("StateListModelId");

                    b.ToTable("StateListModel");

                    b.HasData(
                        new { StateListModelId = 1, Value = "AK" },
                        new { StateListModelId = 2, Value = "AL" },
                        new { StateListModelId = 3, Value = "AR" },
                        new { StateListModelId = 4, Value = "AZ" },
                        new { StateListModelId = 5, Value = "CA" },
                        new { StateListModelId = 6, Value = "CO" },
                        new { StateListModelId = 7, Value = "CT" },
                        new { StateListModelId = 8, Value = "DC" },
                        new { StateListModelId = 9, Value = "DE" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.SubContractCompany", b =>
                {
                    b.Property<int>("SubContractCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<bool>("AssignNewOrders");

                    b.Property<bool?>("IsViewAllWoS");

                    b.Property<int?>("SubContractorCompanyCompanyListModelId");

                    b.HasKey("SubContractCompanyId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("SubContractorCompanyCompanyListModelId");

                    b.ToTable("SubContractCompanies");
                });

            modelBuilder.Entity("KitcPPW.Models.SystemOfRecordListModel", b =>
                {
                    b.Property<int>("SystemOfRecordListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("SystemOfRecordListModelId");

                    b.ToTable("SystemOfRecordListModel");

                    b.HasData(
                        new { SystemOfRecordListModelId = 1, Value = "Aspen Irecord" },
                        new { SystemOfRecordListModelId = 2, Value = "Eastpoint Systems (Field Com)" },
                        new { SystemOfRecordListModelId = 3, Value = "EZ Inspections" },
                        new { SystemOfRecordListModelId = 4, Value = "Inspectorade" },
                        new { SystemOfRecordListModelId = 5, Value = "Pruvan" },
                        new { SystemOfRecordListModelId = 6, Value = "Other" },
                        new { SystemOfRecordListModelId = 7, Value = "Property Pres Wizard (PPW)" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.TimeZoneListModel", b =>
                {
                    b.Property<int>("TimeZoneListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("TimeZoneListModelId");

                    b.ToTable("TimeZoneListModel");

                    b.HasData(
                        new { TimeZoneListModelId = 1, Value = "Central (CDT)" },
                        new { TimeZoneListModelId = 2, Value = "Eastern (EDT)" },
                        new { TimeZoneListModelId = 3, Value = "Mountain (MDT)" },
                        new { TimeZoneListModelId = 4, Value = "Pacific (PDT)" },
                        new { TimeZoneListModelId = 5, Value = "Hawaii (HST)" },
                        new { TimeZoneListModelId = 6, Value = "Guam (ChST)" }
                    );
                });

            modelBuilder.Entity("KitcPPW.Models.WorkOrder", b =>
                {
                    b.Property<int>("WorkOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("AdminId");

                    b.Property<int>("BackgroundCheckinProviderListModelId");

                    b.Property<string>("BrokerCompany");

                    b.Property<string>("BrokerEmail");

                    b.Property<string>("BrokerName");

                    b.Property<string>("BrokerPhone");

                    b.Property<DateTime>("CancelDate");

                    b.Property<int>("CategoryListModelId");

                    b.Property<string>("City");

                    b.Property<DateTime>("ClientDueDate");

                    b.Property<string>("ClientEmail");

                    b.Property<string>("ClientName");

                    b.Property<string>("ClientPhone");

                    b.Property<string>("Comments");

                    b.Property<int>("CompanyListModelId");

                    b.Property<DateTime>("CompleteDate");

                    b.Property<string>("ContractorId");

                    b.Property<string>("CreatedUserId");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("GateCode");

                    b.Property<bool>("IsBATF");

                    b.Property<bool>("IsInspection");

                    b.Property<bool>("IsMissingInfo");

                    b.Property<bool>("IsNeedsReviewedAsap");

                    b.Property<bool>("IsReadyForField");

                    b.Property<bool>("IsRecurring");

                    b.Property<string>("KeyCode");

                    b.Property<string>("LastUpdateByUserId");

                    b.Property<DateTime>("LastUpdateTime");

                    b.Property<int>("LoanNumber");

                    b.Property<string>("LoanType");

                    b.Property<string>("LockCode");

                    b.Property<string>("LockLocation");

                    b.Property<string>("LotSize");

                    b.Property<string>("MissingInfoComment");

                    b.Property<string>("Mortgager");

                    b.Property<int?>("OrderStatusId");

                    b.Property<int>("PPW");

                    b.Property<DateTime>("ReceivedDate");

                    b.Property<DateTime>("RecursCutOffDate");

                    b.Property<int>("RecursEvery");

                    b.Property<int?>("RecursTypeListModelId");

                    b.Property<int>("RushListModelId");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("StateListModelId");

                    b.Property<string>("WorkOrderNumber");

                    b.Property<int>("WorkTypeListModelId");

                    b.Property<int>("ZipCode");

                    b.HasKey("WorkOrderId");

                    b.HasIndex("AdminId");

                    b.HasIndex("BackgroundCheckinProviderListModelId");

                    b.HasIndex("CategoryListModelId");

                    b.HasIndex("CompanyListModelId");

                    b.HasIndex("ContractorId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("LastUpdateByUserId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("RecursTypeListModelId");

                    b.HasIndex("RushListModelId");

                    b.HasIndex("StateListModelId");

                    b.HasIndex("WorkTypeListModelId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("KitcPPW.Models.WorkOrderFieldChangeHistory", b =>
                {
                    b.Property<long>("WorkOrderFieldChangeHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FieldName");

                    b.Property<DateTime>("ModifyDateTime");

                    b.Property<string>("OldValue");

                    b.Property<string>("UserId");

                    b.Property<int>("WorkOrderId");

                    b.HasKey("WorkOrderFieldChangeHistoryId");

                    b.HasIndex("UserId");

                    b.ToTable("WorkOrderFieldChangeHistories");
                });

            modelBuilder.Entity("KitcPPW.Models.WorkTypeListModel", b =>
                {
                    b.Property<int>("WorkTypeListModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Value");

                    b.HasKey("WorkTypeListModelId");

                    b.ToTable("WorkTypeListModel");

                    b.HasData(
                        new { WorkTypeListModelId = 1, Value = "Additional Bid" },
                        new { WorkTypeListModelId = 2, Value = "Bid Approval" },
                        new { WorkTypeListModelId = 3, Value = "Bid Request" },
                        new { WorkTypeListModelId = 4, Value = "Bid Request Dual Control" },
                        new { WorkTypeListModelId = 5, Value = "Bypass Repairs" },
                        new { WorkTypeListModelId = 6, Value = "Cash 4 Keys" },
                        new { WorkTypeListModelId = 7, Value = "Clear Boarding" },
                        new { WorkTypeListModelId = 8, Value = "Continuing REO Service" },
                        new { WorkTypeListModelId = 9, Value = "Conveyance Condition" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KitcPPW.Models.AccessHistory", b =>
                {
                    b.HasOne("KitcPPW.Models.WorkOrder")
                        .WithMany("AccessHistoryList")
                        .HasForeignKey("WorkOrderId");
                });

            modelBuilder.Entity("KitcPPW.Models.ApplicationUser", b =>
                {
                    b.HasOne("KitcPPW.Models.StateListModel", "StateListModel")
                        .WithMany()
                        .HasForeignKey("StateListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.SystemOfRecordListModel", "SystemOfRecord")
                        .WithMany()
                        .HasForeignKey("SystemOfRecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.TimeZoneListModel", "TimeZoneListModel")
                        .WithMany()
                        .HasForeignKey("TimeZoneListModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KitcPPW.Models.LineItem", b =>
                {
                    b.HasOne("KitcPPW.Models.LineItemDescriptionListModel", "LineItemDescriptionListModel")
                        .WithMany()
                        .HasForeignKey("LineItemDescriptionListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.WorkOrder")
                        .WithMany("LineItemList")
                        .HasForeignKey("WorkOrderId");
                });

            modelBuilder.Entity("KitcPPW.Models.OrderAccessHistory", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("KitcPPW.Models.SubContractCompany", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser")
                        .WithMany("SubContractCompanies")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("KitcPPW.Models.CompanyListModel", "SubContractorCompany")
                        .WithMany()
                        .HasForeignKey("SubContractorCompanyCompanyListModelId");
                });

            modelBuilder.Entity("KitcPPW.Models.WorkOrder", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.HasOne("KitcPPW.Models.BackgroundCheckinProviderListModel", "BackgroundCheckinProviderListModel")
                        .WithMany()
                        .HasForeignKey("BackgroundCheckinProviderListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.CategoryListModel", "CategoryListModel")
                        .WithMany()
                        .HasForeignKey("CategoryListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.CompanyListModel", "CompanyListModel")
                        .WithMany()
                        .HasForeignKey("CompanyListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.ApplicationUser", "Contractor")
                        .WithMany()
                        .HasForeignKey("ContractorId");

                    b.HasOne("KitcPPW.Models.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("KitcPPW.Models.ApplicationUser", "LastUpdateByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdateByUserId");

                    b.HasOne("KitcPPW.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("KitcPPW.Models.RecursTypeListModel", "RecursTypeListModel")
                        .WithMany()
                        .HasForeignKey("RecursTypeListModelId");

                    b.HasOne("KitcPPW.Models.RushListModel", "RushListModel")
                        .WithMany()
                        .HasForeignKey("RushListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.StateListModel", "StateListModel")
                        .WithMany()
                        .HasForeignKey("StateListModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.WorkTypeListModel", "WorkTypeListModel")
                        .WithMany()
                        .HasForeignKey("WorkTypeListModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KitcPPW.Models.WorkOrderFieldChangeHistory", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KitcPPW.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("KitcPPW.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
