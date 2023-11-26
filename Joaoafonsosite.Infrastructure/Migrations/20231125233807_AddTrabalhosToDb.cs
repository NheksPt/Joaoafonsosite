using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joaoafonsosite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTrabalhosToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trabalho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tamanho = table.Column<double>(type: "float", nullable: false),
                    SoftwareUsado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracao = table.Column<double>(type: "float", nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataDeEdicao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabalho", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trabalho");
        }
    }
}
