using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PWęgrzyniak_Zadanie2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pracowniks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracowniks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zadanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CzyZakończone = table.Column<bool>(type: "bit", nullable: false),
                    PracownikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zadanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zadanies_Pracowniks_PracownikId",
                        column: x => x.PracownikId,
                        principalTable: "Pracowniks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zadanies_PracownikId",
                table: "Zadanies",
                column: "PracownikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zadanies");

            migrationBuilder.DropTable(
                name: "Pracowniks");
        }
    }
}
