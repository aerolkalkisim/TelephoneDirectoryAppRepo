using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("08ef8223-5583-45d9-b145-0fa4b7d1f117"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("1787d027-77d2-4337-8c2c-8877cadf0d33"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("3e3701bd-8083-4284-b27a-59dadb98f6d1"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("66563ba7-fa94-4a51-b3ed-ff9454f68502"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("db9ce0e7-2e8e-4dcd-9b3d-466224cf6bac"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1787d027-77d2-4337-8c2c-8877cadf0d33"), "Telefon Numarası" },
                    { new Guid("db9ce0e7-2e8e-4dcd-9b3d-466224cf6bac"), "Ev Telefon Numarası" },
                    { new Guid("08ef8223-5583-45d9-b145-0fa4b7d1f117"), "İşyeri Telefon Numarası" },
                    { new Guid("3e3701bd-8083-4284-b27a-59dadb98f6d1"), "Email" },
                    { new Guid("66563ba7-fa94-4a51-b3ed-ff9454f68502"), "Konum" }
                });
        }
    }
}
