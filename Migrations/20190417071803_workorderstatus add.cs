using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class workorderstatusadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadyForOffice",
                table: "OrderStatus");

            migrationBuilder.AddColumn<int>(
                name: "WorkOrderStatus",
                table: "WorkOrders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkOrderStatus",
                table: "WorkOrders");

            migrationBuilder.AddColumn<bool>(
                name: "ReadyForOffice",
                table: "OrderStatus",
                nullable: false,
                defaultValue: false);
        }
    }
}
