using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace microserviceSeguros.Infrastruture.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apolice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<int>(type: "int", nullable: false),
                    situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    premiototal = table.Column<decimal>(name: "premio_total", type: "decimal(18,2)", nullable: false),
                    datacriacaoregistro = table.Column<DateTime>(name: "data_criacao_registro", type: "datetime2", nullable: false),
                    dataalteracaoregistro = table.Column<DateTime>(name: "data_alteracao_registro", type: "datetime2", nullable: false),
                    usuariocriacaoregistro = table.Column<int>(name: "usuario_criacao_registro", type: "int", nullable: false),
                    usuarioalteracaoregistro = table.Column<int>(name: "usuario_alteracao_registro", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apolice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parcelas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apoliceId = table.Column<int>(type: "int", nullable: false),
                    premio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    formapagamento = table.Column<string>(name: "forma_pagamento", type: "nvarchar(max)", nullable: false),
                    datapagamento = table.Column<DateTime>(name: "data_pagamento", type: "datetime2", nullable: false),
                    datapago = table.Column<DateTime>(name: "data_pago", type: "datetime2", nullable: false),
                    juros = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datacriacaoregistro = table.Column<DateTime>(name: "data_criacao_registro", type: "datetime2", nullable: false),
                    dataalteracaoregistro = table.Column<DateTime>(name: "data_alteracao_registro", type: "datetime2", nullable: false),
                    usuariocriacaoregistro = table.Column<int>(name: "usuario_criacao_registro", type: "int", nullable: false),
                    usuarioalteracaoregistro = table.Column<int>(name: "usuario_alteracao_registro", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcelas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parcelas_Apolice_apoliceId",
                        column: x => x.apoliceId,
                        principalTable: "Apolice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parcelas_apoliceId",
                table: "Parcelas",
                column: "apoliceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcelas");

            migrationBuilder.DropTable(
                name: "Apolice");
        }
    }
}
