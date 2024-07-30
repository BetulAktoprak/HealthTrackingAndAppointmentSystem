using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class doctorAddedByHasData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Phone", "Specialty" },
                values: new object[,]
                {
                    { new Guid("0f7154db-2e75-4512-b94d-fb6a5224fb4b"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                    { new Guid("21f7b28b-35c1-4a51-98a9-4521a9a19058"), "İstanbul", "serdar@gmail.com", "Serdar", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                    { new Guid("73b8eaa6-75fc-408c-af17-466c9903b596"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("73bc5174-550d-4b7a-b864-273ad4ff90f9"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" },
                    { new Guid("d8ecda9b-ef71-4bbb-8f4a-386ceab4fa03"), "İstanbul", "aybars@gmail.com", "Aybars", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("dea89c8d-eed8-4791-a433-f5e787bf4361"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Şener", "5555555555", "Genel Cerrahi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0f7154db-2e75-4512-b94d-fb6a5224fb4b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("21f7b28b-35c1-4a51-98a9-4521a9a19058"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("73b8eaa6-75fc-408c-af17-466c9903b596"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("73bc5174-550d-4b7a-b864-273ad4ff90f9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d8ecda9b-ef71-4bbb-8f4a-386ceab4fa03"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("dea89c8d-eed8-4791-a433-f5e787bf4361"));
        }
    }
}
