using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_DataAccess.Migrations
{
    public partial class MyInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    YearBuild = table.Column<short>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    MonthlyRent = table.Column<double>(nullable: false),
                    GrossYield = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
