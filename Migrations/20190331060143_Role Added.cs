using Microsoft.EntityFrameworkCore.Migrations;

namespace KitcPPW.Migrations
{
    public partial class RoleAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "SystemOfRecordListModel",
                columns: new[] { "SystemOfRecordListModelId", "Value" },
                values: new object[,]
                {
                    { 1, "Aspen Irecord" },
                    { 2, "Eastpoint Systems (Field Com)" },
                    { 3, "EZ Inspections" },
                    { 4, "Inspectorade" },
                    { 5, "Pruvan" },
                    { 6, "Other" },
                    { 7, "Property Pres Wizard (PPW)" }
                });

            migrationBuilder.InsertData(
                table: "TimeZoneListModel",
                columns: new[] { "TimeZoneListModelId", "Value" },
                values: new object[,]
                {
                    { 1, "Central (CDT)" },
                    { 2, "Eastern (EDT)" },
                    { 3, "Mountain (MDT)" },
                    { 4, "Pacific (PDT)" },
                    { 5, "Hawaii (HST)" },
                    { 6, "Guam (ChST)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SystemOfRecordListModel",
                keyColumn: "SystemOfRecordListModelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TimeZoneListModel",
                keyColumn: "TimeZoneListModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TimeZoneListModel",
                keyColumn: "TimeZoneListModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TimeZoneListModel",
                keyColumn: "TimeZoneListModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TimeZoneListModel",
                keyColumn: "TimeZoneListModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TimeZoneListModel",
                keyColumn: "TimeZoneListModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TimeZoneListModel",
                keyColumn: "TimeZoneListModelId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
