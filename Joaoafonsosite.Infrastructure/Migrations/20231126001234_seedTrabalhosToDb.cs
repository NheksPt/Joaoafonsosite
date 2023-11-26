using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Joaoafonsosite.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedTrabalhosToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trabalho",
                columns: new[] { "Id", "DataDeCriacao", "DataDeEdicao", "Descricao", "Duracao", "Imagem", "Nome", "SoftwareUsado", "Tamanho", "Tipo" },
                values: new object[,]
                {
                    { 1, null, null, "Animação de comboio, noturna .", 0.5, "https://placehold.co/600x400", "Train to Tokyo", "Blender, After Effects", 50.0, "Animação" },
                    { 2, null, null, "Animação, floresta, cogumelos, borboletas.", 0.5, "https://placehold.co/600x401", "Glowing Mushroom", "Blender", 120.0, "Animação" },
                    { 3, null, null, "Animação morgue abandonada, luzes a piscar ambiente de terror.", 0.5, "https://placehold.co/600x402", "Rigor Mortis", "Blender", 80.0, "Animação" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trabalho",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trabalho",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trabalho",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
