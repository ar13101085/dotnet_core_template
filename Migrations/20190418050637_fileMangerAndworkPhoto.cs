using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class fileMangerAndworkPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileManagers",
                columns: table => new
                {
                    FileManagerId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OriginalFileName = table.Column<string>(nullable: true),
                    FileSizeInKb = table.Column<int>(nullable: false),
                    FileType = table.Column<string>(nullable: true),
                    Lat = table.Column<decimal>(nullable: false),
                    Lng = table.Column<decimal>(nullable: false),
                    Altitude = table.Column<decimal>(nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileManagers", x => x.FileManagerId);
                });

            migrationBuilder.CreateTable(
                name: "OrderPhotos",
                columns: table => new
                {
                    WorkOrderPhotoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkOrderId = table.Column<int>(nullable: false),
                    FileId = table.Column<long>(nullable: false),
                    Label = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPhotos", x => x.WorkOrderPhotoId);
                    table.ForeignKey(
                        name: "FK_OrderPhotos_FileManagers_FileId",
                        column: x => x.FileId,
                        principalTable: "FileManagers",
                        principalColumn: "FileManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPhotos_FileId",
                table: "OrderPhotos",
                column: "FileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderPhotos");

            migrationBuilder.DropTable(
                name: "FileManagers");
        }
    }
}
