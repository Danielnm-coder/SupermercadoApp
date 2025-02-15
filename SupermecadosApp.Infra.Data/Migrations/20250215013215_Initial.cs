using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermecadosApp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTOS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PRECO = table.Column<decimal>(type: "decimal(10,2)", nullable: false, defaultValue: 0m),
                    QUANTIDADEEMESTOQUE = table.Column<int>(type: "int", nullable: false),
                    CATEGOTIA_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PRODUTOS_CATEGORIAS_CATEGOTIA_ID",
                        column: x => x.CATEGOTIA_ID,
                        principalTable: "CATEGORIAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_Nome",
                table: "CATEGORIAS",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_CATEGOTIA_ID",
                table: "PRODUTOS",
                column: "CATEGOTIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTOS_NOME",
                table: "PRODUTOS",
                column: "NOME",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTOS");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");
        }
    }
}
