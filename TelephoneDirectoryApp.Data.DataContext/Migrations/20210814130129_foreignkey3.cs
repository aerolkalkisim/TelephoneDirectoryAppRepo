using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class foreignkey3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_TypeId",
                table: "ContactInformations");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ContactInformationTypeId",
                table: "ContactInformations",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9d6b4f7c-b702-4c8b-b72e-24005d5a9744"), "Telefon Numarası" },
                    { new Guid("2e4d80d2-cff0-4539-85e9-7fdb711f4325"), "Ev Telefon Numarası" },
                    { new Guid("05257b07-ec1b-4def-8142-3f960b5f21c8"), "İşyeri Telefon Numarası" },
                    { new Guid("7900137f-93f4-441c-ae60-dde217d4fead"), "Email" },
                    { new Guid("5c6443d0-71f4-4310-827c-c9c9cdf7b7ae"), "Konum" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_ContactInformationTypeId",
                table: "ContactInformations",
                column: "ContactInformationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_ContactInformationType_ContactInformati~",
                table: "ContactInformations",
                column: "ContactInformationTypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_ContactInformationType_ContactInformati~",
                table: "ContactInformations");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_ContactInformationTypeId",
                table: "ContactInformations");

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("05257b07-ec1b-4def-8142-3f960b5f21c8"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("2e4d80d2-cff0-4539-85e9-7fdb711f4325"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("5c6443d0-71f4-4310-827c-c9c9cdf7b7ae"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7900137f-93f4-441c-ae60-dde217d4fead"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("9d6b4f7c-b702-4c8b-b72e-24005d5a9744"));

            migrationBuilder.DropColumn(
                name: "ContactInformationTypeId",
                table: "ContactInformations");

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

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_TypeId",
                table: "ContactInformations",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations",
                column: "TypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
