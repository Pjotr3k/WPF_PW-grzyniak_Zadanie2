using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWęgrzyniak_Zadanie2.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CzyZakończone",
                table: "Zadanies",
                newName: "CzyZakonczone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CzyZakonczone",
                table: "Zadanies",
                newName: "CzyZakończone");
        }
    }
}
