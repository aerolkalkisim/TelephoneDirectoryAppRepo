using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class firmisnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("1447e086-acc0-437d-bcf6-db78c80472ac"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("692978af-2c18-4dc6-acc1-d6a27ea1430d"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("92939e4e-b61a-495e-8017-95a0bb0eea9d"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("cf538227-da76-40d9-8bcc-596fbfefca7c"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("e9524d7c-c282-4797-8bd8-7e51d8a62f63"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("692978af-2c18-4dc6-acc1-d6a27ea1430d"), "Telefon Numarası" },
                    { new Guid("e9524d7c-c282-4797-8bd8-7e51d8a62f63"), "Ev Telefon Numarası" },
                    { new Guid("1447e086-acc0-437d-bcf6-db78c80472ac"), "İşyeri Telefon Numarası" },
                    { new Guid("92939e4e-b61a-495e-8017-95a0bb0eea9d"), "Email" },
                    { new Guid("cf538227-da76-40d9-8bcc-596fbfefca7c"), "Konum" }
                });
        }
    }
}
