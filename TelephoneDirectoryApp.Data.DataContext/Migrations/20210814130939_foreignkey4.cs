using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class foreignkey4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "TypeId",
                table: "ContactInformationType",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "ContactInformationType",
                columns: new[] { "Id", "Name", "TypeId" },
                values: new object[,]
                {
                    { new Guid("7132384e-d1c4-4073-b8ff-47b693325b7e"), "Telefon Numarası", null },
                    { new Guid("907701fe-059c-4550-9e93-bebd4bbc7570"), "Ev Telefon Numarası", null },
                    { new Guid("7111d69e-8eaa-472b-b537-27853d0d999f"), "İşyeri Telefon Numarası", null },
                    { new Guid("e75ea07c-eacb-43b9-b6ad-5c8c7bb9a40b"), "Email", null },
                    { new Guid("0e189838-8781-46f3-bbed-07007abe67df"), "Konum", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformationType_TypeId",
                table: "ContactInformationType",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformationType_ContactInformationType_TypeId",
                table: "ContactInformationType",
                column: "TypeId",
                principalTable: "ContactInformationType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformationType_ContactInformationType_TypeId",
                table: "ContactInformationType");

            migrationBuilder.DropIndex(
                name: "IX_ContactInformationType_TypeId",
                table: "ContactInformationType");

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("0e189838-8781-46f3-bbed-07007abe67df"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7111d69e-8eaa-472b-b537-27853d0d999f"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("7132384e-d1c4-4073-b8ff-47b693325b7e"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("907701fe-059c-4550-9e93-bebd4bbc7570"));

            migrationBuilder.DeleteData(
                table: "ContactInformationType",
                keyColumn: "Id",
                keyValue: new Guid("e75ea07c-eacb-43b9-b6ad-5c8c7bb9a40b"));

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "ContactInformationType");

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
        }
    }
}
