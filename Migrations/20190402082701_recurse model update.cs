using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class recursemodelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_RecursTypeListModel_RecursTypeListModelId",
                table: "WorkOrders");

            migrationBuilder.AlterColumn<int>(
                name: "RecursTypeListModelId",
                table: "WorkOrders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "RecursTypeListModel",
                columns: new[] { "RecursTypeListModelId", "Value" },
                values: new object[] { 1, "Day(s)" });

            migrationBuilder.InsertData(
                table: "RecursTypeListModel",
                columns: new[] { "RecursTypeListModelId", "Value" },
                values: new object[] { 2, "Week(s)" });

            migrationBuilder.InsertData(
                table: "RecursTypeListModel",
                columns: new[] { "RecursTypeListModelId", "Value" },
                values: new object[] { 3, "Month(s)" });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_RecursTypeListModel_RecursTypeListModelId",
                table: "WorkOrders",
                column: "RecursTypeListModelId",
                principalTable: "RecursTypeListModel",
                principalColumn: "RecursTypeListModelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_RecursTypeListModel_RecursTypeListModelId",
                table: "WorkOrders");

            migrationBuilder.DeleteData(
                table: "RecursTypeListModel",
                keyColumn: "RecursTypeListModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecursTypeListModel",
                keyColumn: "RecursTypeListModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecursTypeListModel",
                keyColumn: "RecursTypeListModelId",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "RecursTypeListModelId",
                table: "WorkOrders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_RecursTypeListModel_RecursTypeListModelId",
                table: "WorkOrders",
                column: "RecursTypeListModelId",
                principalTable: "RecursTypeListModel",
                principalColumn: "RecursTypeListModelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
