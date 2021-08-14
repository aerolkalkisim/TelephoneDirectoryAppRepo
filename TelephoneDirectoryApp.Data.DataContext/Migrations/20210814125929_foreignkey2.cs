using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class foreignkey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("4f6bbf98-76c7-42b3-b8ac-a1830c8f46a6"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("6ab88f0e-d7b2-4602-9a3a-98c21e5fb22d"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("aeefcf5b-6635-4e9a-8091-6b3bf658f896"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("bd4fa31e-fb8b-4044-867d-3c98ff226c1b"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("e6cf5342-dd46-4e41-85d3-a12c9287bece"));

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b4fe6287-6888-44e1-a342-2eb1835bc944"), "Telefon Numarası" },
                    { new Guid("15f5add5-e734-4959-8ad3-ef172731a181"), "Ev Telefon Numarası" },
                    { new Guid("845645f8-612f-4503-9b7e-7990446cec17"), "İşyeri Telefon Numarası" },
                    { new Guid("d681d810-6d0c-45da-a0a7-3aa837fceb82"), "Email" },
                    { new Guid("949e29e9-7e22-4215-9c4c-b99855ecb5f3"), "Konum" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("15f5add5-e734-4959-8ad3-ef172731a181"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("845645f8-612f-4503-9b7e-7990446cec17"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("949e29e9-7e22-4215-9c4c-b99855ecb5f3"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("b4fe6287-6888-44e1-a342-2eb1835bc944"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("d681d810-6d0c-45da-a0a7-3aa837fceb82"));

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6ab88f0e-d7b2-4602-9a3a-98c21e5fb22d"), "Telefon Numarası" },
                    { new Guid("4f6bbf98-76c7-42b3-b8ac-a1830c8f46a6"), "Ev Telefon Numarası" },
                    { new Guid("aeefcf5b-6635-4e9a-8091-6b3bf658f896"), "İşyeri Telefon Numarası" },
                    { new Guid("e6cf5342-dd46-4e41-85d3-a12c9287bece"), "Email" },
                    { new Guid("bd4fa31e-fb8b-4044-867d-3c98ff226c1b"), "Konum" }
                });
        }
    }
}
