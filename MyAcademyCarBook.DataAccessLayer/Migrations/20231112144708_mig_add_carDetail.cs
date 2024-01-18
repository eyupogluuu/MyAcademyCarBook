using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyCarBook.DataAccessLayer.Migrations
{
    public partial class mig_add_carDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carDetails",
                columns: table => new
                {
                    carDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descreption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carID = table.Column<int>(type: "int", nullable: false),
                    AppUser = table.Column<int>(type: "int", nullable: false),
                    appuserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carDetails", x => x.carDetailID);
                    table.ForeignKey(
                        name: "FK_carDetails_AspNetUsers_appuserId",
                        column: x => x.appuserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_carDetails_cars_carID",
                        column: x => x.carID,
                        principalTable: "cars",
                        principalColumn: "carID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carDetails_appuserId",
                table: "carDetails",
                column: "appuserId");

            migrationBuilder.CreateIndex(
                name: "IX_carDetails_carID",
                table: "carDetails",
                column: "carID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carDetails");
        }
    }
}
