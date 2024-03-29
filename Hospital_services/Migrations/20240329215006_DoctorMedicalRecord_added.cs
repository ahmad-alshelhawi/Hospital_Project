using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_services.Migrations
{
    /// <inheritdoc />
    public partial class DoctorMedicalRecord_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actionLogs_Users_UserId",
                table: "actionLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorMedicalRecord_Doctors_DoctorId",
                table: "DoctorMedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorMedicalRecord_MedicalRecords_MedicalRecordId",
                table: "DoctorMedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_medicinePrescriptions_Medicines_MedicineId",
                table: "medicinePrescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_medicinePrescriptions_Prescriptions_PrescriptionId",
                table: "medicinePrescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicinePrescriptions",
                table: "medicinePrescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_actionLogs",
                table: "actionLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorMedicalRecord",
                table: "DoctorMedicalRecord");

            migrationBuilder.RenameTable(
                name: "medicinePrescriptions",
                newName: "MedicinePrescriptions");

            migrationBuilder.RenameTable(
                name: "actionLogs",
                newName: "ActionLogs");

            migrationBuilder.RenameTable(
                name: "DoctorMedicalRecord",
                newName: "DoctorMedicalRecords");

            migrationBuilder.RenameIndex(
                name: "IX_medicinePrescriptions_PrescriptionId",
                table: "MedicinePrescriptions",
                newName: "IX_MedicinePrescriptions_PrescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_medicinePrescriptions_MedicineId",
                table: "MedicinePrescriptions",
                newName: "IX_MedicinePrescriptions_MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_actionLogs_UserId",
                table: "ActionLogs",
                newName: "IX_ActionLogs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorMedicalRecord_MedicalRecordId",
                table: "DoctorMedicalRecords",
                newName: "IX_DoctorMedicalRecords_MedicalRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorMedicalRecord_DoctorId",
                table: "DoctorMedicalRecords",
                newName: "IX_DoctorMedicalRecords_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicinePrescriptions",
                table: "MedicinePrescriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionLogs",
                table: "ActionLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorMedicalRecords",
                table: "DoctorMedicalRecords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionLogs_Users_UserId",
                table: "ActionLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorMedicalRecords_Doctors_DoctorId",
                table: "DoctorMedicalRecords",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorMedicalRecords_MedicalRecords_MedicalRecordId",
                table: "DoctorMedicalRecords",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicinePrescriptions_Medicines_MedicineId",
                table: "MedicinePrescriptions",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicinePrescriptions_Prescriptions_PrescriptionId",
                table: "MedicinePrescriptions",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionLogs_Users_UserId",
                table: "ActionLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorMedicalRecords_Doctors_DoctorId",
                table: "DoctorMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorMedicalRecords_MedicalRecords_MedicalRecordId",
                table: "DoctorMedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicinePrescriptions_Medicines_MedicineId",
                table: "MedicinePrescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicinePrescriptions_Prescriptions_PrescriptionId",
                table: "MedicinePrescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicinePrescriptions",
                table: "MedicinePrescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionLogs",
                table: "ActionLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorMedicalRecords",
                table: "DoctorMedicalRecords");

            migrationBuilder.RenameTable(
                name: "MedicinePrescriptions",
                newName: "medicinePrescriptions");

            migrationBuilder.RenameTable(
                name: "ActionLogs",
                newName: "actionLogs");

            migrationBuilder.RenameTable(
                name: "DoctorMedicalRecords",
                newName: "DoctorMedicalRecord");

            migrationBuilder.RenameIndex(
                name: "IX_MedicinePrescriptions_PrescriptionId",
                table: "medicinePrescriptions",
                newName: "IX_medicinePrescriptions_PrescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicinePrescriptions_MedicineId",
                table: "medicinePrescriptions",
                newName: "IX_medicinePrescriptions_MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_ActionLogs_UserId",
                table: "actionLogs",
                newName: "IX_actionLogs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorMedicalRecords_MedicalRecordId",
                table: "DoctorMedicalRecord",
                newName: "IX_DoctorMedicalRecord_MedicalRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorMedicalRecords_DoctorId",
                table: "DoctorMedicalRecord",
                newName: "IX_DoctorMedicalRecord_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicinePrescriptions",
                table: "medicinePrescriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_actionLogs",
                table: "actionLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorMedicalRecord",
                table: "DoctorMedicalRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_actionLogs_Users_UserId",
                table: "actionLogs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorMedicalRecord_Doctors_DoctorId",
                table: "DoctorMedicalRecord",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorMedicalRecord_MedicalRecords_MedicalRecordId",
                table: "DoctorMedicalRecord",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id");

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
    }
}
