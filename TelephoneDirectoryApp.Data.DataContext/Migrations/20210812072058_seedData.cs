using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneDirectoryApp.Data.DataContext.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
