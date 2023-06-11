using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeterinarskaStanica.Services.Migrations
{
    /// <inheritdoc />
    public partial class ZaposleniciRadnaMjesta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZaposleniciRadnaMjesta",
                columns: table => new
                {
                    ZaposlenikRadnoMjestoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZaposlenikID = table.Column<int>(type: "int", nullable: false),
                    RadnoMjestoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZaposleniciRadnaMjesta", x => x.ZaposlenikRadnoMjestoID);
                    table.ForeignKey(
                        name: "FK_ZaposleniciRadnaMjesta_RadnoMjesto",
                        column: x => x.RadnoMjestoID,
                        principalTable: "RadnaMjesta",
                        principalColumn: "RadnaMjestaID");
                    table.ForeignKey(
                        name: "FK_ZaposleniciRadnaMjesta_Zaposlenik",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenici",
                        principalColumn: "ZaposlenikID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZaposleniciRadnaMjesta_RadnoMjestoID",
                table: "ZaposleniciRadnaMjesta",
                column: "RadnoMjestoID");

            migrationBuilder.CreateIndex(
                name: "IX_ZaposleniciRadnaMjesta_ZaposlenikID",
                table: "ZaposleniciRadnaMjesta",
                column: "ZaposlenikID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZaposleniciRadnaMjesta");
        }
    }
}
