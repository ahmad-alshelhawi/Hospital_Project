using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_services.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedicineId",
                table: "Medicines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "Manufacturers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InventoryId",
                table: "Inventory",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Medicines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Medicines",
                newName: "MedicineId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Manufacturers",
                newName: "ManufacturerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventory",
                newName: "InventoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");
        }
    }
}
