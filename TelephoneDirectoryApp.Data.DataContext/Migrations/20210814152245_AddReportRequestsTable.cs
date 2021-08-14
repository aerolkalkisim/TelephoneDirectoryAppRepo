using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class AddReportRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("488fc82b-c837-46cd-8f1d-8eeb4a7fa802"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7aae9cfb-7810-4fc5-ad50-8498ba356282"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7d0fd2b4-9783-4aae-ad76-a4ba4fae7e1e"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7e653d32-2d9e-406a-9c3b-a9dbd3f66e82"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("c10d034c-c94d-4c37-8675-4cef675b199b"));

            migrationBuilder.CreateTable(
                name: "ReportRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Result = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportRequests", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportRequests");

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

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "ContactInformationTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("488fc82b-c837-46cd-8f1d-8eeb4a7fa802"), null, "Telefon Numarası" },
                    { new Guid("c10d034c-c94d-4c37-8675-4cef675b199b"), null, "Ev Telefon Numarası" },
                    { new Guid("7d0fd2b4-9783-4aae-ad76-a4ba4fae7e1e"), null, "İşyeri Telefon Numarası" },
                    { new Guid("7e653d32-2d9e-406a-9c3b-a9dbd3f66e82"), null, "Email" },
                    { new Guid("7aae9cfb-7810-4fc5-ad50-8498ba356282"), null, "Konum" }
                });
        }
    }
}
