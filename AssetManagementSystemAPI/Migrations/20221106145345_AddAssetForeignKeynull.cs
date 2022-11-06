using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagementSystemAPI.Migrations
{
    public partial class AddAssetForeignKeynull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_AssetType_AssetTypeId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_CpuType_CpuId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_HarddiscType_HddId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_RamType_RamId",
                table: "AddAsset");

            migrationBuilder.AlterColumn<int>(
                name: "RamId",
                table: "AddAsset",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HddId",
                table: "AddAsset",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CpuId",
                table: "AddAsset",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "AddAsset",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_AssetType_AssetTypeId",
                table: "AddAsset",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_CpuType_CpuId",
                table: "AddAsset",
                column: "CpuId",
                principalTable: "CpuType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_HarddiscType_HddId",
                table: "AddAsset",
                column: "HddId",
                principalTable: "HarddiscType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_RamType_RamId",
                table: "AddAsset",
                column: "RamId",
                principalTable: "RamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_AssetType_AssetTypeId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_CpuType_CpuId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_HarddiscType_HddId",
                table: "AddAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_AddAsset_RamType_RamId",
                table: "AddAsset");

            migrationBuilder.AlterColumn<int>(
                name: "RamId",
                table: "AddAsset",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HddId",
                table: "AddAsset",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CpuId",
                table: "AddAsset",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetTypeId",
                table: "AddAsset",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddAsset_AssetType_AssetTypeId",
                table: "AddAsset",
                column: "AssetTypeId",
                principalTable: "AssetType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
