using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class OrderStatusCategoryremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatus_CategoryListModel_CategoryId",
                table: "OrderStatus");

            migrationBuilder.DropIndex(
                name: "IX_OrderStatus_CategoryId",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "OrderStatus");

            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "WorkOrderFieldChangeHistories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "WorkOrderFieldChangeHistories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "OrderStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_CategoryId",
                table: "OrderStatus",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatus_CategoryListModel_CategoryId",
                table: "OrderStatus",
                column: "CategoryId",
                principalTable: "CategoryListModel",
                principalColumn: "CategoryListModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
