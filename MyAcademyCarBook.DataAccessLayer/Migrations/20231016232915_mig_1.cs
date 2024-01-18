using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    brandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandName = table.Column<int>(type: "int", nullable: false),
                    brandStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.brandID);
                });

            migrationBuilder.CreateTable(
                name: "carCategories",
                columns: table => new
                {
                    carcategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carcategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cateStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carCategories", x => x.carcategoryID);
                });

            migrationBuilder.CreateTable(
                name: "carStatuses",
                columns: table => new
                {
                    carStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carStatuses", x => x.carStatusID);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    locationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    locStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.locationID);
                });

            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    carID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carcategoryID = table.Column<int>(type: "int", nullable: false),
                    brandID = table.Column<int>(type: "int", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gearType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KM = table.Column<int>(type: "int", nullable: false),
                    personCount = table.Column<byte>(type: "tinyint", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    cstatus = table.Column<bool>(type: "bit", nullable: false),
                    carStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.carID);
                    table.ForeignKey(
                        name: "FK_cars_brands_brandID",
                        column: x => x.brandID,
                        principalTable: "brands",
                        principalColumn: "brandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cars_carCategories_carcategoryID",
                        column: x => x.carcategoryID,
                        principalTable: "carCategories",
                        principalColumn: "carcategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cars_carStatuses_carStatusID",
                        column: x => x.carStatusID,
                        principalTable: "carStatuses",
                        principalColumn: "carStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "prices",
                columns: table => new
                {
                    priceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carID = table.Column<int>(type: "int", nullable: false),
                    priceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priceValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prices", x => x.priceID);
                    table.ForeignKey(
                        name: "FK_prices_cars_carID",
                        column: x => x.carID,
                        principalTable: "cars",
                        principalColumn: "carID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_brandID",
                table: "cars",
                column: "brandID");

            migrationBuilder.CreateIndex(
                name: "IX_cars_carcategoryID",
                table: "cars",
                column: "carcategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_cars_carStatusID",
                table: "cars",
                column: "carStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_prices_carID",
                table: "prices",
                column: "carID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "prices");

            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "carCategories");

            migrationBuilder.DropTable(
                name: "carStatuses");
        }
    }
}
