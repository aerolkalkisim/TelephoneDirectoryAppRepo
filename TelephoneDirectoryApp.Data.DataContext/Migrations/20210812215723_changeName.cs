using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class changeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("11720b52-9942-45fe-92aa-a2dba4a05fa3"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("2d221cbf-1d17-4de5-8c44-f28c90b16f74"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("4e0d6960-e7d8-42d4-8769-38364c90d252"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("70e1e630-c248-472f-8d79-8e57bfb912be"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("a1669a40-504c-45ba-a36c-6c2307b3d3e0"));

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ContactInformations",
                newName: "Value");

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a202f620-64c1-4011-aac0-b6b690d8f47c"), "Telefon Numarası" },
                    { new Guid("71be4c15-ab69-454a-b935-f7ca83013fe6"), "Ev Telefon Numarası" },
                    { new Guid("15dbc2a6-207f-4ed9-b0db-2e54b065a81c"), "İşyeri Telefon Numarası" },
                    { new Guid("36899bb1-ec30-4f33-9c5c-c8883a41ed16"), "Email" },
                    { new Guid("1f0ee246-ded3-4f9e-9ef0-f991eb8600d0"), "Konum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("15dbc2a6-207f-4ed9-b0db-2e54b065a81c"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("1f0ee246-ded3-4f9e-9ef0-f991eb8600d0"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("36899bb1-ec30-4f33-9c5c-c8883a41ed16"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("71be4c15-ab69-454a-b935-f7ca83013fe6"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("a202f620-64c1-4011-aac0-b6b690d8f47c"));

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "ContactInformations",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4e0d6960-e7d8-42d4-8769-38364c90d252"), "Telefon Numarası" },
                    { new Guid("a1669a40-504c-45ba-a36c-6c2307b3d3e0"), "Ev Telefon Numarası" },
                    { new Guid("2d221cbf-1d17-4de5-8c44-f28c90b16f74"), "İşyeri Telefon Numarası" },
                    { new Guid("70e1e630-c248-472f-8d79-8e57bfb912be"), "Email" },
                    { new Guid("11720b52-9942-45fe-92aa-a2dba4a05fa3"), "Konum" }
                });
        }
    }
}
