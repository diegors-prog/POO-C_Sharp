using Microsoft.EntityFrameworkCore.Migrations;

namespace AP2_POO.Migrations
{
    public partial class pagamentoRealizadoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PagamentoRealizado",
                table: "Contas",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PagamentoRealizado",
                table: "Contas");
        }
    }
}
