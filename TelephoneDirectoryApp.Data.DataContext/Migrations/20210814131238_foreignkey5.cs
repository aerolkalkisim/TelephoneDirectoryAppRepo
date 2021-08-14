using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class foreignkey5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
