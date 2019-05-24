using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class update_file_manager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSizeInKb",
                table: "FileManagers",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<decimal>(
                name: "FileName",
                table: "FileManagers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "FileManagers");

            migrationBuilder.AlterColumn<int>(
                name: "FileSizeInKb",
                table: "FileManagers",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
