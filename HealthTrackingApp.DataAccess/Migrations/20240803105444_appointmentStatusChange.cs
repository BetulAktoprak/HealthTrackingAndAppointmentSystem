using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class appointmentStatusChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("28c73858-de82-4718-81a5-e25024ff2689"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("345d9a6b-5a5a-423a-9cce-f30888bc1f06"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("43a3caf6-1a60-40a6-b0b3-7f23d80aebb4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4bd06cdd-d66a-473c-9b5e-604ffcaec9ce"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5324af46-c02a-462d-a800-a937fd656281"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("55673b20-c0ac-442a-8ec1-073727a66d60"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("764035b2-53b4-4d0f-bbea-0505f81637c8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cb657d7e-b1ef-4ea5-87b1-212a73570985"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e7d51ee0-15ac-450f-829b-3af2bf11b701"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f94edc5b-6909-453f-ace0-3f66c3191cd0"));

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "Email", "FirstName", "FullName", "LastName", "Phone", "Specialty" },
                values: new object[,]
                {
                    { new Guid("08709540-c8d0-4e88-9b7d-cd0ae75be504"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Neslihan Şenocak", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("295620bf-63be-4d7a-8aa5-910077a50811"), "İstanbul", "metin@gmail.com", "Metin", "Metin Güler", "Güler", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("3ceca3a8-c508-4a5b-9df9-0c23cbbde174"), "İstanbul", "serdar@gmail.com", "Serdar", "Serdar Saraç", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                    { new Guid("3e64b615-6280-40d1-bba7-722eba30af61"), "İstanbul", "bahadır@gmail.com", "Bahadır", "Bahadır Baykal", "Baykal", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("4b092e1e-ddd7-4c02-b89d-ab0a1efb800d"), "İstanbul", "haydar@gmail.com", "Haydar", "Haydar Yalman", "Yalman", "5555555555", "Genel Cerrahi" },
                    { new Guid("4eaa5a87-3a12-4450-8c8e-451e354942eb"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Altıntaş", "Altıntaş", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("5cc936a6-a629-4740-a4b1-3b01a798d376"), "İstanbul", "aybars@gmail.com", "Aybars", "Aybars Akkor", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("7d462c25-fdad-41ba-833e-79b4b57d043e"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Akgül", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                    { new Guid("85433f1c-b966-420d-a61c-8e714f39c2fd"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Mustafa Şener", "Şener", "5555555555", "Genel Cerrahi" },
                    { new Guid("dba7660f-65e8-4d29-ac41-4003f0978ea0"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Alparslan Baksu", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("08709540-c8d0-4e88-9b7d-cd0ae75be504"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("295620bf-63be-4d7a-8aa5-910077a50811"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3ceca3a8-c508-4a5b-9df9-0c23cbbde174"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("3e64b615-6280-40d1-bba7-722eba30af61"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4b092e1e-ddd7-4c02-b89d-ab0a1efb800d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4eaa5a87-3a12-4450-8c8e-451e354942eb"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5cc936a6-a629-4740-a4b1-3b01a798d376"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7d462c25-fdad-41ba-833e-79b4b57d043e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("85433f1c-b966-420d-a61c-8e714f39c2fd"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("dba7660f-65e8-4d29-ac41-4003f0978ea0"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "Email", "FirstName", "FullName", "LastName", "Phone", "Specialty" },
                values: new object[,]
                {
                    { new Guid("28c73858-de82-4718-81a5-e25024ff2689"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Mustafa Şener", "Şener", "5555555555", "Genel Cerrahi" },
                    { new Guid("345d9a6b-5a5a-423a-9cce-f30888bc1f06"), "İstanbul", "serdar@gmail.com", "Serdar", "Serdar Saraç", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                    { new Guid("43a3caf6-1a60-40a6-b0b3-7f23d80aebb4"), "İstanbul", "haydar@gmail.com", "Haydar", "Haydar Yalman", "Yalman", "5555555555", "Genel Cerrahi" },
                    { new Guid("4bd06cdd-d66a-473c-9b5e-604ffcaec9ce"), "İstanbul", "bahadır@gmail.com", "Bahadır", "Bahadır Baykal", "Baykal", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("5324af46-c02a-462d-a800-a937fd656281"), "İstanbul", "metin@gmail.com", "Metin", "Metin Güler", "Güler", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("55673b20-c0ac-442a-8ec1-073727a66d60"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Altıntaş", "Altıntaş", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("764035b2-53b4-4d0f-bbea-0505f81637c8"), "İstanbul", "aybars@gmail.com", "Aybars", "Aybars Akkor", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("cb657d7e-b1ef-4ea5-87b1-212a73570985"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Akgül", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                    { new Guid("e7d51ee0-15ac-450f-829b-3af2bf11b701"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Alparslan Baksu", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" },
                    { new Guid("f94edc5b-6909-453f-ace0-3f66c3191cd0"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Neslihan Şenocak", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" }
                });
        }
    }
}
