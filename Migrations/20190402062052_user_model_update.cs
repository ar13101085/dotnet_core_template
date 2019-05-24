using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class user_model_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignGroupRoleId",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignGroupRoleId",
                table: "AspNetUsers");
        }
    }
}
