using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedICollectionToPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("304846a8-b604-4737-9885-9997d7a9bc20"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5948cd45-148e-4830-ba7d-ff9859e31d9c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("78d759ef-995f-4776-9442-d3d11b5682f6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("831b941b-f7f3-481e-abe6-a5ef8dfc6c33"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("92aff278-3bb3-49bc-9286-f84d040ed2fb"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9993ca88-3c36-46bd-a384-fc2576def601"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b27b42b5-9dcb-45ac-8c43-69430fa053f0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d3f95929-f223-43f0-b811-217c8760b410"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e2fed086-91e0-4343-a610-20a81368adc8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e4bf6304-5f37-4a5b-8543-7fd45bbced5c"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "Email", "FirstName", "FullName", "LastName", "Phone", "Specialty" },
                values: new object[,]
                {
                    { new Guid("09fc2ca1-7db0-41bd-8374-61ae298eba2c"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Altıntaş", "Altıntaş", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("13f6ffee-a613-4e3c-a525-c4be04ef1983"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Akgül", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                    { new Guid("4f5021a4-5d69-4444-a6d9-28f5c104f5a5"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Alparslan Baksu", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" },
                    { new Guid("50cd4e36-5d9a-42ee-a5bd-ceef36f72afe"), "İstanbul", "bahadır@gmail.com", "Bahadır", "Bahadır Baykal", "Baykal", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("548d5aaf-ce2a-47c8-817f-28de9ce65509"), "İstanbul", "serdar@gmail.com", "Serdar", "Serdar Saraç", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                    { new Guid("67aaf196-0da8-42b0-9cd5-d9fe487ad604"), "İstanbul", "metin@gmail.com", "Metin", "Metin Güler", "Güler", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("8060ad47-fa0e-4cfb-8ffd-1177b180f76f"), "İstanbul", "haydar@gmail.com", "Haydar", "Haydar Yalman", "Yalman", "5555555555", "Genel Cerrahi" },
                    { new Guid("a50847be-fdea-4ae9-9634-4b38a7ab7137"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Neslihan Şenocak", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("ee9b6c0c-a421-4711-9c39-c13cb6d3c1aa"), "İstanbul", "aybars@gmail.com", "Aybars", "Aybars Akkor", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("febc7c30-b8c1-4e45-9675-eb543919a6a0"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Mustafa Şener", "Şener", "5555555555", "Genel Cerrahi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("09fc2ca1-7db0-41bd-8374-61ae298eba2c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("13f6ffee-a613-4e3c-a525-c4be04ef1983"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4f5021a4-5d69-4444-a6d9-28f5c104f5a5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("50cd4e36-5d9a-42ee-a5bd-ceef36f72afe"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("548d5aaf-ce2a-47c8-817f-28de9ce65509"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("67aaf196-0da8-42b0-9cd5-d9fe487ad604"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8060ad47-fa0e-4cfb-8ffd-1177b180f76f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a50847be-fdea-4ae9-9634-4b38a7ab7137"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ee9b6c0c-a421-4711-9c39-c13cb6d3c1aa"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("febc7c30-b8c1-4e45-9675-eb543919a6a0"));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "Email", "FirstName", "FullName", "LastName", "Phone", "Specialty" },
                values: new object[,]
                {
                    { new Guid("304846a8-b604-4737-9885-9997d7a9bc20"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Neslihan Şenocak", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("5948cd45-148e-4830-ba7d-ff9859e31d9c"), "İstanbul", "metin@gmail.com", "Metin", "Metin Güler", "Güler", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("78d759ef-995f-4776-9442-d3d11b5682f6"), "İstanbul", "bahadır@gmail.com", "Bahadır", "Bahadır Baykal", "Baykal", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("831b941b-f7f3-481e-abe6-a5ef8dfc6c33"), "İstanbul", "serdar@gmail.com", "Serdar", "Serdar Saraç", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                    { new Guid("92aff278-3bb3-49bc-9286-f84d040ed2fb"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Alparslan Baksu", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" },
                    { new Guid("9993ca88-3c36-46bd-a384-fc2576def601"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Akgül", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                    { new Guid("b27b42b5-9dcb-45ac-8c43-69430fa053f0"), "İstanbul", "haydar@gmail.com", "Haydar", "Haydar Yalman", "Yalman", "5555555555", "Genel Cerrahi" },
                    { new Guid("d3f95929-f223-43f0-b811-217c8760b410"), "İstanbul", "aybars@gmail.com", "Aybars", "Aybars Akkor", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                    { new Guid("e2fed086-91e0-4343-a610-20a81368adc8"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Altıntaş", "Altıntaş", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                    { new Guid("e4bf6304-5f37-4a5b-8543-7fd45bbced5c"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Mustafa Şener", "Şener", "5555555555", "Genel Cerrahi" }
                });
        }
    }
}
