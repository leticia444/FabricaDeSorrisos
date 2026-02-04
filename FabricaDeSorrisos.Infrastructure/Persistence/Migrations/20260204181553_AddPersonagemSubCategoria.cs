using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FabricaDeSorrisos.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPersonagemSubCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Brinquedos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoriaId",
                table: "Brinquedos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategorias_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brinquedos_PersonagemId",
                table: "Brinquedos",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Brinquedos_SubCategoriaId",
                table: "Brinquedos",
                column: "SubCategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategorias_CategoriaId",
                table: "SubCategorias",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brinquedos_Personagens_PersonagemId",
                table: "Brinquedos",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Brinquedos_SubCategorias_SubCategoriaId",
                table: "Brinquedos",
                column: "SubCategoriaId",
                principalTable: "SubCategorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brinquedos_Personagens_PersonagemId",
                table: "Brinquedos");

            migrationBuilder.DropForeignKey(
                name: "FK_Brinquedos_SubCategorias_SubCategoriaId",
                table: "Brinquedos");

            migrationBuilder.DropTable(
                name: "Personagens");

            migrationBuilder.DropTable(
                name: "SubCategorias");

            migrationBuilder.DropIndex(
                name: "IX_Brinquedos_PersonagemId",
                table: "Brinquedos");

            migrationBuilder.DropIndex(
                name: "IX_Brinquedos_SubCategoriaId",
                table: "Brinquedos");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Brinquedos");

            migrationBuilder.DropColumn(
                name: "SubCategoriaId",
                table: "Brinquedos");
        }
    }
}
