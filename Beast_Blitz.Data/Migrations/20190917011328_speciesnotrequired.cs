using Microsoft.EntityFrameworkCore.Migrations;

namespace Beast_Blitz.Data.Migrations
{
    public partial class speciesnotrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Species_SpeciesID",
                table: "Monsters");

            migrationBuilder.AlterColumn<int>(
                name: "SpeciesID",
                table: "Monsters",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Items",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Species_SpeciesID",
                table: "Monsters",
                column: "SpeciesID",
                principalTable: "Species",
                principalColumn: "SpeciesID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monsters_Species_SpeciesID",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "SpeciesID",
                table: "Monsters",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Monsters_Species_SpeciesID",
                table: "Monsters",
                column: "SpeciesID",
                principalTable: "Species",
                principalColumn: "SpeciesID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
