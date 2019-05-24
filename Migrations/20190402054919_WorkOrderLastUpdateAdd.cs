using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class WorkOrderLastUpdateAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "WorkOrders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdateByUserId",
                table: "WorkOrders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateTime",
                table: "WorkOrders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_CreatedUserId",
                table: "WorkOrders",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_LastUpdateByUserId",
                table: "WorkOrders",
                column: "LastUpdateByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_AspNetUsers_CreatedUserId",
                table: "WorkOrders",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOrders_AspNetUsers_LastUpdateByUserId",
                table: "WorkOrders",
                column: "LastUpdateByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_AspNetUsers_CreatedUserId",
                table: "WorkOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkOrders_AspNetUsers_LastUpdateByUserId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_CreatedUserId",
                table: "WorkOrders");

            migrationBuilder.DropIndex(
                name: "IX_WorkOrders_LastUpdateByUserId",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "LastUpdateByUserId",
                table: "WorkOrders");

            migrationBuilder.DropColumn(
                name: "LastUpdateTime",
                table: "WorkOrders");
        }
    }
}
