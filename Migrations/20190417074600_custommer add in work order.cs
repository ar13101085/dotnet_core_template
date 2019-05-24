using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class custommeraddinworkorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerListModelId",
                table: "WorkOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_CustomerListModelId",
                table: "WorkOrders",
                column: "CustomerListModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_CustomerListModel_CustomerListModelId",
                table: "WorkOrders",
                column: "CustomerListModelId",
                principalTable: "CustomerListModel",
                principalColumn: "CustomerListModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_CustomerListModel_CustomerListModelId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_CustomerListModelId",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "CustomerListModelId",
                table: "WorkOrders");
        }
    }
}
