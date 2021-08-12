using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class contactIsActiveColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("3c28cfd8-617f-4638-b8e4-b2004b5817c8"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7b0f7615-ca1c-4f7b-b88b-6b896f056543"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("cec0d803-e098-4e53-b4c3-7a6164bfb248"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("df26f5cb-3c42-412b-abef-292e9d543efa"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("f6937266-425f-4c95-a756-46261143063b"));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Contacts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Contacts");

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f6937266-425f-4c95-a756-46261143063b"), "Telefon Numarası" },
                    { new Guid("3c28cfd8-617f-4638-b8e4-b2004b5817c8"), "Ev Telefon Numarası" },
                    { new Guid("7b0f7615-ca1c-4f7b-b88b-6b896f056543"), "İşyeri Telefon Numarası" },
                    { new Guid("cec0d803-e098-4e53-b4c3-7a6164bfb248"), "Email" },
                    { new Guid("df26f5cb-3c42-412b-abef-292e9d543efa"), "Konum" }
                });
        }
    }
}
