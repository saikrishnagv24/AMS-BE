using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagementSystemAPI.Migrations
{
    public partial class AddAssetForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AddAsset_CpuId",
                table: "AddAsset",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_AddAsset_HddId",
                table: "AddAsset",
                column: "HddId");

            migrationBuilder.CreateIndex(
                name: "IX_AddAsset_RamId",
                table: "AddAsset",
                column: "RamId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_CpuType_CpuId",
                table: "AddAsset",
                column: "CpuId",
                principalTable: "CpuType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_HarddiscType_HddId",
                table: "AddAsset",
                column: "HddId",
                principalTable: "HarddiscType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_RamType_RamId",
                table: "AddAsset",
                column: "RamId",
                principalTable: "RamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_CpuType_CpuId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_HarddiscType_HddId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_RamType_RamId",
                table: "AddAsset");

            migrationBuilder.DropIndex(
                name: "IX_AddAsset_CpuId",
                table: "AddAsset");

            migrationBuilder.DropIndex(
                name: "IX_AddAsset_HddId",
                table: "AddAsset");

            migrationBuilder.DropIndex(
                name: "IX_AddAsset_RamId",
                table: "AddAsset");
        }
    }
}
