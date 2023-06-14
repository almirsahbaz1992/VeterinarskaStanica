using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeterinarskaStanica.Services.Migrations
{
    /// <inheritdoc />
    public partial class dataseedfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Proizvodi",
                keyColumn: "ProizvodID",
                keyValue: 3,
                column: "Opis",
                value: "Detaljan opis kupke!");

            migrationBuilder.UpdateData(
                table: "Proizvodi",
                keyColumn: "ProizvodID",
                keyValue: 4,
                column: "Opis",
                value: "Detaljan opis šampona!");

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                column: "DatumRezervacije",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Zaposlenici",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                column: "DatumZaposlenja",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Zaposlenici",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                column: "DatumZaposlenja",
                value: new DateTime(2023, 6, 14, 22, 59, 36, 625, DateTimeKind.Local).AddTicks(1545));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Narudzbe",
                keyColumn: "NarudzbaID",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Proizvodi",
                keyColumn: "ProizvodID",
                keyValue: 3,
                column: "Opis",
                value: "Detaljan opis lijeka protiv krpelja!");

            migrationBuilder.UpdateData(
                table: "Proizvodi",
                keyColumn: "ProizvodID",
                keyValue: 4,
                column: "Opis",
                value: "Detaljan opis lijeka protiv krpelja!");

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Rezervacije",
                keyColumn: "RezervacijaID",
                keyValue: 3,
                column: "DatumRezervacije",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Zaposlenici",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                column: "DatumZaposlenja",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Zaposlenici",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                column: "DatumZaposlenja",
                value: new DateTime(2023, 6, 14, 22, 46, 15, 552, DateTimeKind.Local).AddTicks(1078));
        }
    }
}
