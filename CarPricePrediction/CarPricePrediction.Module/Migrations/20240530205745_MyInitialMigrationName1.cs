using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPricePrediction.Module.Migrations
{
    /// <inheritdoc />
    public partial class MyInitialMigrationName1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VwCars",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mileage = table.Column<int>(type: "int", nullable: true),
                    fuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tax = table.Column<int>(type: "int", nullable: true),
                    mpg = table.Column<double>(type: "float", nullable: true),
                    engineSize = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VwCars", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VwCars");
        }
    }
}
