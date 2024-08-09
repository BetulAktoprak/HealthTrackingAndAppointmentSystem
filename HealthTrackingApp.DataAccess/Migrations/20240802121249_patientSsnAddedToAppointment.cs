using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations;

/// <inheritdoc />
public partial class patientSsnAddedToAppointment : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
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

        migrationBuilder.AlterColumn<string>(
            name: "SSN",
            table: "Patients",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: "",
            oldClrType: typeof(string),
            oldType: "nvarchar(max)",
            oldNullable: true);

        migrationBuilder.AddColumn<string>(
            name: "SSN",
            table: "Appointments",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: "");

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

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
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

        migrationBuilder.DropColumn(
            name: "SSN",
            table: "Appointments");

        migrationBuilder.AlterColumn<string>(
            name: "SSN",
            table: "Patients",
            type: "nvarchar(max)",
            nullable: true,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

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
}
