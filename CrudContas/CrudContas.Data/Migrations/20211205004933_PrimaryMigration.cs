using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudContas.Data.Migrations
{
    public partial class PrimaryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Contas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.DropIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Contas");
        }
    }
}
