using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_services.Migrations
{
    /// <inheritdoc />
    public partial class MedicinePrescription_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicinePrescription_Medicines_MedicineId",
                table: "MedicinePrescription");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicinePrescription_Prescriptions_PrescriptionId",
                table: "MedicinePrescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicinePrescription",
                table: "MedicinePrescription");

            migrationBuilder.RenameTable(
                name: "MedicinePrescription",
                newName: "medicinePrescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_MedicinePrescription_PrescriptionId",
                table: "medicinePrescriptions",
                newName: "IX_medicinePrescriptions_PrescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicinePrescription_MedicineId",
                table: "medicinePrescriptions",
                newName: "IX_medicinePrescriptions_MedicineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicinePrescriptions",
                table: "medicinePrescriptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicinePrescriptions_Medicines_MedicineId",
                table: "medicinePrescriptions",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_medicinePrescriptions_Prescriptions_PrescriptionId",
                table: "medicinePrescriptions",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicinePrescriptions_Medicines_MedicineId",
                table: "medicinePrescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_medicinePrescriptions_Prescriptions_PrescriptionId",
                table: "medicinePrescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicinePrescriptions",
                table: "medicinePrescriptions");

            migrationBuilder.RenameTable(
                name: "medicinePrescriptions",
                newName: "MedicinePrescription");

            migrationBuilder.RenameIndex(
                name: "IX_medicinePrescriptions_PrescriptionId",
                table: "MedicinePrescription",
                newName: "IX_MedicinePrescription_PrescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_medicinePrescriptions_MedicineId",
                table: "MedicinePrescription",
                newName: "IX_MedicinePrescription_MedicineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicinePrescription",
                table: "MedicinePrescription",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicinePrescription_Medicines_MedicineId",
                table: "MedicinePrescription",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicinePrescription_Prescriptions_PrescriptionId",
                table: "MedicinePrescription",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");
        }
    }
}
