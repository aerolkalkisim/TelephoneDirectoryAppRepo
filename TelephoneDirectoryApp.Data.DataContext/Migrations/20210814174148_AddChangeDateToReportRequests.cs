using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class AddChangeDateToReportRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("550d492d-6fc0-46c2-b993-0937f09972e5"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("68c7026d-d3a0-4f39-b724-473e221aaa44"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("8aba81e1-8539-4a02-ba02-655f9e6cd8a5"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("c19b73c3-1f0a-497f-bd7e-824a658480ce"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("fa1cdb89-a3f9-4154-bd86-284b12f10dd2"));

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusChangeDate",
                table: "ReportRequests",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "ContactInformationTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("9cfcc4d7-2f10-4444-9fc2-237e7083ca25"), null, "Telefon Numarası" },
                    { new Guid("e7a88065-3917-4658-ad9e-a7f667dd42d4"), null, "Ev Telefon Numarası" },
                    { new Guid("ed2db277-af35-4e6c-a22f-99cbf5fa13d5"), null, "İşyeri Telefon Numarası" },
                    { new Guid("c90db09f-7f67-4574-9ac2-64a9e00a58a8"), null, "Email" },
                    { new Guid("2bf7e653-3f0a-45bc-a2a8-da2f8f7e10e8"), null, "Konum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("2bf7e653-3f0a-45bc-a2a8-da2f8f7e10e8"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("9cfcc4d7-2f10-4444-9fc2-237e7083ca25"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("c90db09f-7f67-4574-9ac2-64a9e00a58a8"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("e7a88065-3917-4658-ad9e-a7f667dd42d4"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("ed2db277-af35-4e6c-a22f-99cbf5fa13d5"));

            migrationBuilder.DropColumn(
                name: "StatusChangeDate",
                table: "ReportRequests");

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "ContactInformationTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("550d492d-6fc0-46c2-b993-0937f09972e5"), null, "Telefon Numarası" },
                    { new Guid("68c7026d-d3a0-4f39-b724-473e221aaa44"), null, "Ev Telefon Numarası" },
                    { new Guid("fa1cdb89-a3f9-4154-bd86-284b12f10dd2"), null, "İşyeri Telefon Numarası" },
                    { new Guid("8aba81e1-8539-4a02-ba02-655f9e6cd8a5"), null, "Email" },
                    { new Guid("c19b73c3-1f0a-497f-bd7e-824a658480ce"), null, "Konum" }
                });
        }
    }
}
