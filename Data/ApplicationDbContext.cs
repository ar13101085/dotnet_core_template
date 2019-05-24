using KitcPPW.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KitcPPW.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<SubContractCompany> SubContractCompanies { get; set; }
        public DbSet<AccessHistory> AccessHistories { get; set; }
        public DbSet<CheckInSync> CheckInSync { get; set; }
        public DbSet<MobileCheckin> MobileCheckin { get; set; }
        public DbSet<CustomerListModel> CustomerListModel { get; set; }
        public DbSet<CompanyListModel> CompanyListModel { get; set; }
        public DbSet<CategoryListModel> CategoryListModel { get; set; }
        public DbSet<WorkTypeListModel> WorkTypeListModel { get; set; }
        public DbSet<StateListModel> StateListModel { get; set; }
        public DbSet<RushListModel> RushListModel { get; set; }
        public DbSet<BackgroundCheckinProviderListModel> BackgroundCheckinProviderListModel { get; set; }
        public DbSet<RecursTypeListModel> RecursTypeListModel { get; set; }
        public DbSet<LineItemDescriptionListModel> LineItemDescriptionListModel { get; set; }
        public DbSet<SystemOfRecordListModel> SystemOfRecordListModel { get; set; }
        public DbSet<TimeZoneListModel> TimeZoneListModel { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<LineItem> LineItem { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderAccessHistory> OrderAccessHistory { get; set; }
        public DbSet<WorkOrderFieldChangeHistory> WorkOrderFieldChangeHistories { get; set; }
        public DbSet<FileManager> FileManagers { get; set; }
        public DbSet<WorkOrderPhoto> OrderPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Here we need to define Fluent API for entity relationship
            //base.OnModelCreating(builder);

            #region Seed Data

            builder.Entity<CustomerListModel>().HasData(
                new CustomerListModel() { CustomerListModelId = 1,Value = "258" },
                new CustomerListModel() { CustomerListModelId = 2, Value = "328" },
                new CustomerListModel() { CustomerListModelId = 3, Value = "335FC Caliber Home Loans" },
                new CustomerListModel() { CustomerListModelId = 4, Value = "335GC Caliber Home Loan" },
                new CustomerListModel() { CustomerListModelId = 5, Value = "357" },
                new CustomerListModel() { CustomerListModelId = 6, Value = "455" },
                new CustomerListModel() { CustomerListModelId = 7, Value = "518" },
                new CustomerListModel() { CustomerListModelId = 8, Value = "659" },
                new CustomerListModel() { CustomerListModelId = 9, Value = "Bank of America" }
            );




            builder.Entity<CompanyListModel>().HasData(
                new CompanyListModel() { CompanyListModelId = 1,Value = "000" },
                new CompanyListModel() { CompanyListModelId = 2, Value = "121" },
                new CompanyListModel() { CompanyListModelId = 3, Value = "1212" },
                new CompanyListModel() { CompanyListModelId = 4, Value = "1213" },
                new CompanyListModel() { CompanyListModelId = 5, Value = "122" },
                new CompanyListModel() { CompanyListModelId = 6, Value = "124" },
                new CompanyListModel() { CompanyListModelId = 7, Value = "125" },
                new CompanyListModel() { CompanyListModelId = 8, Value = "191" },
                new CompanyListModel() { CompanyListModelId = 9, Value = "1910" }
            );



            builder.Entity<CategoryListModel>().HasData(
                new CategoryListModel() { CategoryListModelId = 1,Value = "10K+ Bid Check" },
                new CategoryListModel() { CategoryListModelId = 2, Value = "3rd Party" },
                new CategoryListModel() { CategoryListModelId = 3, Value = "Dummy, Do not Assign" },
                new CategoryListModel() { CategoryListModelId = 4, Value = "Fred Williams" },
                new CategoryListModel() { CategoryListModelId = 5, Value = "Ready to Assign" },
                new CategoryListModel() { CategoryListModelId = 6, Value = "Reassignment Needed" },
                new CategoryListModel() { CategoryListModelId = 7, Value = "RTV" },
                new CategoryListModel() { CategoryListModelId = 8, Value = "RUSH" },
                new CategoryListModel() { CategoryListModelId = 9, Value = "RUSH RTV" }
            );


            builder.Entity<WorkTypeListModel>().HasData(
                new WorkTypeListModel() { WorkTypeListModelId = 1,Value = "Additional Bid" },
                new WorkTypeListModel() { WorkTypeListModelId = 2, Value = "Bid Approval" },
                new WorkTypeListModel() { WorkTypeListModelId = 3, Value = "Bid Request" },
                new WorkTypeListModel() { WorkTypeListModelId = 4, Value = "Bid Request Dual Control" },
                new WorkTypeListModel() { WorkTypeListModelId = 5, Value = "Bypass Repairs" },
                new WorkTypeListModel() { WorkTypeListModelId = 6, Value = "Cash 4 Keys" },
                new WorkTypeListModel() { WorkTypeListModelId = 7, Value = "Clear Boarding" },
                new WorkTypeListModel() { WorkTypeListModelId = 8, Value = "Continuing REO Service" },
                new WorkTypeListModel() { WorkTypeListModelId = 9, Value = "Conveyance Condition" }
            );


            builder.Entity<StateListModel>().HasData(
                new StateListModel() { StateListModelId = 1,Value = "AK" },
                new StateListModel() { StateListModelId = 2, Value = "AL" },
                new StateListModel() { StateListModelId = 3, Value = "AR" },
                new StateListModel() { StateListModelId = 4, Value = "AZ" },
                new StateListModel() { StateListModelId = 5, Value = "CA" },
                new StateListModel() { StateListModelId = 6, Value = "CO" },
                new StateListModel() { StateListModelId = 7, Value = "CT" },
                new StateListModel() { StateListModelId = 8, Value = "DC" },
                new StateListModel() { StateListModelId = 9, Value = "DE" }
            );



            


            builder.Entity<RushListModel>().HasData(
                new RushListModel() { RushListModelId = 1, Value = "RUSH" },
                new RushListModel() { RushListModelId = 2, Value = "RVM's RUSH" }
            );



            builder.Entity<BackgroundCheckinProviderListModel>().HasData(
                new BackgroundCheckinProviderListModel() { BackgroundCheckinProviderListModelId = 1, Value = "Aspen Grove Solutions" },
                new BackgroundCheckinProviderListModel() { BackgroundCheckinProviderListModelId = 2, Value = "ServiceLink" }
            );
            builder.Entity<LineItemDescriptionListModel>().HasData(
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 1, Value = "Lock Set" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 2, Value = "Rush Fee" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 3, Value = "Additional Lockset - After Main Door Secure" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 4, Value = "Additional Lock / Dead Bolt-After Main Door Secure" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 5, Value = "Animal Removal - (Small, med. large)" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 6, Value = "Antimicrobial Treatment (open beams, subfloors)" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 7, Value = "Antimicrobial Treatment (walls, ceilings, )" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 8, Value = "Basement Pumping, Up To 1000SF Up to 2' Deep" },
                new LineItemDescriptionListModel() { LineItemDescriptionListModelId = 9, Value = "Basement Pumping, Over 1000SF Up to 1' Deep" }
            );


            builder.Entity<SystemOfRecordListModel>().HasData(
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 1, Value = "Aspen Irecord" },
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 2, Value = "Eastpoint Systems (Field Com)" },
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 3, Value = "EZ Inspections" },
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 4, Value = "Inspectorade" },
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 5, Value = "Pruvan" },
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 6, Value = "Other" },
                new SystemOfRecordListModel() { SystemOfRecordListModelId = 7, Value = "Property Pres Wizard (PPW)" }
            );

            builder.Entity<TimeZoneListModel>().HasData(
                new TimeZoneListModel() { TimeZoneListModelId = 1, Value = "Central (CDT)" },
                new TimeZoneListModel() { TimeZoneListModelId = 2, Value = "Eastern (EDT)" },
                new TimeZoneListModel() { TimeZoneListModelId = 3, Value = "Mountain (MDT)" },
                new TimeZoneListModel() { TimeZoneListModelId = 4, Value = "Pacific (PDT)" },
                new TimeZoneListModel() { TimeZoneListModelId = 5, Value = "Hawaii (HST)" },
                new TimeZoneListModel() { TimeZoneListModelId = 6, Value = "Guam (ChST)" }
            );


            builder.Entity<RecursTypeListModel>().HasData(
                new RecursTypeListModel() { RecursTypeListModelId = 1, Value = "Day(s)" },
                new RecursTypeListModel() { RecursTypeListModelId = 2, Value = "Week(s)" },
                new RecursTypeListModel() { RecursTypeListModelId = 3, Value = "Month(s)" }
            );

            #endregion
            base.OnModelCreating(builder);
        }
    }
}