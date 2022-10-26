using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagementSystemAPI.Migrations
{
    public partial class AssetTypeupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AssetType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "AssetType",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AssetType");

            migrationBuilder.DropColumn(
                name: "status",
                table: "AssetType");
        }
    }
}
