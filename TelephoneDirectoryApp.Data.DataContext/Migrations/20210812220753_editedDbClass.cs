using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class editedDbClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_Contacts_ContactId",
                table: "ContactInformations");

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
                name: "ContactId",
                table: "ContactInformations",
                newName: "GatewayId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInformations_ContactId",
                table: "ContactInformations",
                newName: "IX_ContactInformations_GatewayId");

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5a1110b0-30fc-4dfa-8d04-ddf4e7be8516"), "Telefon Numarası" },
                    { new Guid("8bf296d1-e56b-48b1-b860-dbef977ae7ee"), "Ev Telefon Numarası" },
                    { new Guid("d988229d-17b5-456f-9e52-4580c1101721"), "İşyeri Telefon Numarası" },
                    { new Guid("6fc6364c-2df7-4b58-a0ae-efd2d163c04e"), "Email" },
                    { new Guid("c22f1adc-fb92-4541-a7c1-cc09f06b3b57"), "Konum" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_Contacts_GatewayId",
                table: "ContactInformations",
                column: "GatewayId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_Contacts_GatewayId",
                table: "ContactInformations");

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("5a1110b0-30fc-4dfa-8d04-ddf4e7be8516"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("6fc6364c-2df7-4b58-a0ae-efd2d163c04e"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("8bf296d1-e56b-48b1-b860-dbef977ae7ee"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("c22f1adc-fb92-4541-a7c1-cc09f06b3b57"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("d988229d-17b5-456f-9e52-4580c1101721"));

            migrationBuilder.RenameColumn(
                name: "GatewayId",
                table: "ContactInformations",
                newName: "ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInformations_GatewayId",
                table: "ContactInformations",
                newName: "IX_ContactInformations_ContactId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_Contacts_ContactId",
                table: "ContactInformations",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
