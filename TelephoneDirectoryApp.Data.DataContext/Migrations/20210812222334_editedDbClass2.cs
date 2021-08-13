using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class editedDbClass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_Contacts_GatewayId",
                table: "ContactInformations");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_GatewayId",
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

            migrationBuilder.DropColumn(
                name: "GatewayId",
                table: "ContactInformations");

            migrationBuilder.AlterColumn<Guid>(
                name: "TypeId",
                table: "ContactInformations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContactId",
                table: "ContactInformations",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_ContactId",
                table: "ContactInformations",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations",
                column: "TypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_Contacts_ContactId",
                table: "ContactInformations",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_Contacts_ContactId",
                table: "ContactInformations");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_ContactId",
                table: "ContactInformations");

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

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "ContactInformations");

            migrationBuilder.AlterColumn<Guid>(
                name: "TypeId",
                table: "ContactInformations",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "GatewayId",
                table: "ContactInformations",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_GatewayId",
                table: "ContactInformations",
                column: "GatewayId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations",
                column: "TypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_Contacts_GatewayId",
                table: "ContactInformations",
                column: "GatewayId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
