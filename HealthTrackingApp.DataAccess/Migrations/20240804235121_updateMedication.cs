using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations;

/// <inheritdoc />
public partial class updateMedication : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
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

        migrationBuilder.DropColumn(
            name: "Medication",
            table: "Prescriptions");

        migrationBuilder.AddColumn<string>(
            name: "Medications",
            table: "Prescriptions",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: "[]");

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

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
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

        migrationBuilder.DropColumn(
            name: "Medications",
            table: "Prescriptions");

        migrationBuilder.AddColumn<string>(
            name: "Medication",
            table: "Prescriptions",
            type: "nvarchar(max)",
            nullable: true);

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
}
