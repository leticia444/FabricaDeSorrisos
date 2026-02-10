using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FabricaDeSorrisos.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AjustePedidoCheckout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosDoSistema_TiposUsuarios_TipoUsuarioId",
                table: "UsuariosDoSistema");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoEntrega",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Pedidos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorFrete",
                table: "Pedidos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosDoSistema_TiposUsuarios_TipoUsuarioId",
                table: "UsuariosDoSistema",
                column: "TipoUsuarioId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosDoSistema_TiposUsuarios_TipoUsuarioId",
                table: "UsuariosDoSistema");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "EnderecoEntrega",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ValorFrete",
                table: "Pedidos");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosDoSistema_TiposUsuarios_TipoUsuarioId",
                table: "UsuariosDoSistema",
                column: "TipoUsuarioId",
                principalTable: "TiposUsuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
