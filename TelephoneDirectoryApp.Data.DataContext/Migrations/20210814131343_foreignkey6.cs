using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class foreignkey6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_ContactInformationType_ContactInformati~",
                table: "ContactInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformationType_ContactInformationType_TypeId",
                table: "ContactInformationType");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_ContactInformationTypeId",
                table: "ContactInformations");

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("089115d9-52d9-46ba-aedb-cbd7c55eb619"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("6cb36c9e-10a3-4b61-b6d5-d03ef029db74"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("862b8ef8-79c2-497e-9ed7-2943a4f50949"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("d8282447-66ce-4f5c-aa71-d6bcc8debe51"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("e2e5d7fb-87d4-442b-8080-f518ef404cee"));

            migrationBuilder.DropColumn(
                name: "ContactInformationTypeId",
                table: "ContactInformations");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "ContactInformationType",
                newName: "ContactInformationTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInformationType_TypeId",
                table: "ContactInformationType",
                newName: "IX_ContactInformationType_ContactInformationTypeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformationType_ContactInformationType_ContactInform~",
                table: "ContactInformationType",
                column: "ContactInformationTypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformations_ContactInformationType_TypeId",
                table: "ContactInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformationType_ContactInformationType_ContactInform~",
                table: "ContactInformationType");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformations_TypeId",
                table: "ContactInformations");

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

            migrationBuilder.RenameColumn(
                name: "ContactInformationTypeId",
                table: "ContactInformationType",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInformationType_ContactInformationTypeId",
                table: "ContactInformationType",
                newName: "IX_ContactInformationType_TypeId");

            migrationBuilder.AddColumn<Guid>(
                name: "ContactInformationTypeId",
                table: "ContactInformations",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name", "TypeId" },
                values: new object[,]
                {
                    { new Guid("e2e5d7fb-87d4-442b-8080-f518ef404cee"), "Telefon Numarası", null },
                    { new Guid("6cb36c9e-10a3-4b61-b6d5-d03ef029db74"), "Ev Telefon Numarası", null },
                    { new Guid("089115d9-52d9-46ba-aedb-cbd7c55eb619"), "İşyeri Telefon Numarası", null },
                    { new Guid("d8282447-66ce-4f5c-aa71-d6bcc8debe51"), "Email", null },
                    { new Guid("862b8ef8-79c2-497e-9ed7-2943a4f50949"), "Konum", null }
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

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformationType_ContactInformationType_TypeId",
                table: "ContactInformationType",
                column: "TypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
