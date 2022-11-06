using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagementSystemAPI.Migrations
{
    public partial class AddAsset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddAsset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetId = table.Column<string>(type: "nvarchar(220)", maxLength: 220, nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: false),
                    CpuId = table.Column<int>(type: "int", nullable: false),
                    RamId = table.Column<int>(type: "int", nullable: false),
                    HddId = table.Column<int>(type: "int", nullable: false),
                    AssetPurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssetCost = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddAsset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddAsset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddAsset_AssetTypeId",
                table: "AddAsset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddAsset");
        }
    }
}
