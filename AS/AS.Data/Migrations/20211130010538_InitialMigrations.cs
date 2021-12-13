using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AS.Data.Migrations
{
  public partial class InitialMigrations : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Clientes",
          columns: table => new
          {
            Id = table.Column<int>(type: "integer", nullable: false)
                  .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            Email = table.Column<string>(type: "text", nullable: true),
            Nome = table.Column<string>(type: "text", nullable: true),
            Fone = table.Column<string>(type: "text", nullable: true),
            DataNasc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Clientes", x => x.Id);
          });

      migrationBuilder.CreateTable(
          name: "Contas",
          columns: table => new
          {
            Id = table.Column<int>(type: "integer", nullable: false)
                  .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            DataLeitura = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
            NumLeitura = table.Column<int>(type: "integer", nullable: false),
            KwGasto = table.Column<int>(type: "integer", nullable: false),
            ValorPagar = table.Column<double>(type: "double precision", nullable: false),
            DataPagamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
            MediaConsumo = table.Column<double>(type: "double precision", nullable: false),
            PagamentoRealizado = table.Column<bool>(type: "boolean", nullable: false),
            ClienteId = table.Column<int>(type: "integer", nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Contas", x => x.Id);
            table.ForeignKey(
                      name: "FK_Contas_Clientes_ClienteId",
                      column: x => x.ClienteId,
                      principalTable: "Clientes",
                      principalColumn: "Id",
                      onDelete: ReferentialAction.Restrict);
          });

      migrationBuilder.CreateIndex(
          name: "IX_Contas_ClienteId",
          table: "Contas",
          column: "ClienteId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Contas");

      migrationBuilder.DropTable(
          name: "Clientes");
    }
  }
}
