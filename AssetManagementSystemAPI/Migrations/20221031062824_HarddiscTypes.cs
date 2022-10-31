using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetManagementSystemAPI.Migrations
{
    public partial class HarddiscType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HarddiscType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HarddiscTypeName = table.Column<string>(type: "nvarchar(220)", maxLength: 220, nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarddiscType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HarddiscType");
        }
    }
}
