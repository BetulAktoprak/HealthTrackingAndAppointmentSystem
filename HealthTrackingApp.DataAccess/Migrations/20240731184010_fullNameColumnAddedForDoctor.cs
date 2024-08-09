using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations;

/// <inheritdoc />
public partial class fullNameColumnAddedForDoctor : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
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

        migrationBuilder.AddColumn<string>(
            name: "FullName",
            table: "Doctors",
            type: "nvarchar(max)",
            nullable: true);

        migrationBuilder.InsertData(
            table: "Doctors",
            columns: new[] { "Id", "Address", "Email", "FirstName", "FullName", "LastName", "Phone", "Specialty" },
            values: new object[,]
            {
                { new Guid("4fe31a83-3744-4867-acf3-faf2dda557d3"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Altıntaş", "Altıntaş", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                { new Guid("629517d4-a67f-4e18-b3c8-b36f457115c1"), "İstanbul", "metin@gmail.com", "Metin", "Metin Güler", "Güler", "5555555555", "Beyin ve Sinir Cerrahisi" },
                { new Guid("6568ec70-c182-49fb-a4d8-2bf4c8354ce0"), "İstanbul", "aybars@gmail.com", "Aybars", "Aybars Akkor", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                { new Guid("692aed0a-97c0-4509-a4e2-ffd52d705fe8"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Alparslan Baksu", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" },
                { new Guid("78af09ae-ce4d-4251-a945-e2039ea8ead2"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Akgül", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                { new Guid("a94b3dc4-ab9b-4911-9717-41f67c08c1fa"), "İstanbul", "serdar@gmail.com", "Serdar", "Serdar Saraç", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                { new Guid("b28c03b4-8df8-44fa-976e-6e551c114efb"), "İstanbul", "haydar@gmail.com", "Haydar", "Haydar Yalman", "Yalman", "5555555555", "Genel Cerrahi" },
                { new Guid("d4c39e80-651e-48a1-b29e-45fc0c8284ff"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Mustafa Şener", "Şener", "5555555555", "Genel Cerrahi" },
                { new Guid("f57a32d6-6571-4e96-9255-cf9936c2cf87"), "İstanbul", "bahadır@gmail.com", "Bahadır", "Bahadır Baykal", "Baykal", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                { new Guid("fac8671c-dc13-4ec0-af00-038a05503ca7"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Neslihan Şenocak", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("4fe31a83-3744-4867-acf3-faf2dda557d3"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("629517d4-a67f-4e18-b3c8-b36f457115c1"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("6568ec70-c182-49fb-a4d8-2bf4c8354ce0"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("692aed0a-97c0-4509-a4e2-ffd52d705fe8"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("78af09ae-ce4d-4251-a945-e2039ea8ead2"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("a94b3dc4-ab9b-4911-9717-41f67c08c1fa"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("b28c03b4-8df8-44fa-976e-6e551c114efb"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("d4c39e80-651e-48a1-b29e-45fc0c8284ff"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("f57a32d6-6571-4e96-9255-cf9936c2cf87"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("fac8671c-dc13-4ec0-af00-038a05503ca7"));

        migrationBuilder.DropColumn(
            name: "FullName",
            table: "Doctors");

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
}
