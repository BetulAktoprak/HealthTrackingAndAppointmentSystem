using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HealthTrackingApp.DataAccess.Migrations;

/// <inheritdoc />
public partial class UpdateForeignKeyConstraints : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
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

        migrationBuilder.AddColumn<Guid>(
            name: "PrescriptionId",
            table: "TreatmentPlans",
            type: "uniqueidentifier",
            nullable: false,
            defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

        migrationBuilder.AddColumn<Guid>(
            name: "PrescriptionId",
            table: "MedicalTests",
            type: "uniqueidentifier",
            nullable: false,
            defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

        migrationBuilder.InsertData(
            table: "Doctors",
            columns: new[] { "Id", "Address", "Email", "FirstName", "FullName", "LastName", "Phone", "Specialty" },
            values: new object[,]
            {
                { new Guid("0d08127c-2725-4883-afea-9526c11db2dc"), "İstanbul", "alparslan@gmail.com", "Alparslan", "Alparslan Baksu", "Baksu", "5555555555", "Kadın Hastalıkları ve Doğum - Jinekoloji" },
                { new Guid("40b27d66-ef48-4194-8c86-08b338593b68"), "İstanbul", "neslihan@gmail.com", "Neslihan", "Neslihan Şenocak", "Şenocak", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                { new Guid("5aafb01b-f64e-4121-9159-03e4e7d04373"), "İstanbul", "bahadır@gmail.com", "Bahadır", "Bahadır Baykal", "Baykal", "5555555555", "Kulak, Burun, Boğaz - KBB" },
                { new Guid("63a107ae-b765-4a32-bde8-ccafa77f887b"), "İstanbul", "haydar@gmail.com", "Haydar", "Haydar Yalman", "Yalman", "5555555555", "Genel Cerrahi" },
                { new Guid("72490b01-c3b9-4ab3-965c-aa9998de1a08"), "İstanbul", "mustafa@gmail.com", "Mustafa", "Mustafa Şener", "Şener", "5555555555", "Genel Cerrahi" },
                { new Guid("7dbfed67-70a3-4e6f-8387-486ba0e3441c"), "İstanbul", "serdar@gmail.com", "Serdar", "Serdar Saraç", "Saraç", "5555555555", "Fizik Tedavi ve Rehabilitasyon" },
                { new Guid("94b2c722-1920-4da3-ae33-71ed11ac220f"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Akgül", "Akgül", "5555555555", "Kalp ve Damar Cerrahisi" },
                { new Guid("9cd55cd5-045e-439c-95b0-52ddb6150cd7"), "İstanbul", "metin@gmail.com", "Metin", "Metin Güler", "Güler", "5555555555", "Beyin ve Sinir Cerrahisi" },
                { new Guid("c7cc2493-97a7-47f2-8139-332d41e222f4"), "İstanbul", "aybars@gmail.com", "Aybars", "Aybars Akkor", "Akkor", "5555555555", "Beyin ve Sinir Cerrahisi" },
                { new Guid("ee2f6ff5-a4cb-442c-9781-492de4aef870"), "İstanbul", "ahmet@gmail.com", "Ahmet", "Ahmet Altıntaş", "Altıntaş", "5555555555", "Kulak, Burun, Boğaz - KBB" }
            });

        migrationBuilder.CreateIndex(
            name: "IX_TreatmentPlans_PrescriptionId",
            table: "TreatmentPlans",
            column: "PrescriptionId");

        migrationBuilder.CreateIndex(
            name: "IX_MedicalTests_PrescriptionId",
            table: "MedicalTests",
            column: "PrescriptionId");

        migrationBuilder.AddForeignKey(
            name: "FK_MedicalTests_Prescriptions_PrescriptionId",
            table: "MedicalTests",
            column: "PrescriptionId",
            principalTable: "Prescriptions",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);

        migrationBuilder.AddForeignKey(
            name: "FK_TreatmentPlans_Prescriptions_PrescriptionId",
            table: "TreatmentPlans",
            column: "PrescriptionId",
            principalTable: "Prescriptions",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_MedicalTests_Prescriptions_PrescriptionId",
            table: "MedicalTests");

        migrationBuilder.DropForeignKey(
            name: "FK_TreatmentPlans_Prescriptions_PrescriptionId",
            table: "TreatmentPlans");

        migrationBuilder.DropIndex(
            name: "IX_TreatmentPlans_PrescriptionId",
            table: "TreatmentPlans");

        migrationBuilder.DropIndex(
            name: "IX_MedicalTests_PrescriptionId",
            table: "MedicalTests");

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("0d08127c-2725-4883-afea-9526c11db2dc"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("40b27d66-ef48-4194-8c86-08b338593b68"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("5aafb01b-f64e-4121-9159-03e4e7d04373"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("63a107ae-b765-4a32-bde8-ccafa77f887b"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("72490b01-c3b9-4ab3-965c-aa9998de1a08"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("7dbfed67-70a3-4e6f-8387-486ba0e3441c"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("94b2c722-1920-4da3-ae33-71ed11ac220f"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("9cd55cd5-045e-439c-95b0-52ddb6150cd7"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("c7cc2493-97a7-47f2-8139-332d41e222f4"));

        migrationBuilder.DeleteData(
            table: "Doctors",
            keyColumn: "Id",
            keyValue: new Guid("ee2f6ff5-a4cb-442c-9781-492de4aef870"));

        migrationBuilder.DropColumn(
            name: "PrescriptionId",
            table: "TreatmentPlans");

        migrationBuilder.DropColumn(
            name: "PrescriptionId",
            table: "MedicalTests");

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
}
