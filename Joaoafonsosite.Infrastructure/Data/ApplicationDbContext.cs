using Joaoafonsosite.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Joaoafonsosite.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Trabalhos> Trabalho { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trabalhos>().HasData(
                new Trabalhos
                {
                    Id = 1,
                    Nome = "Train to Tokyo",
                    Tipo = "Animação",
                    Descricao = "Animação de comboio, noturna .",
                    Tamanho = 50,
                    SoftwareUsado = "Blender, After Effects",
                    Duracao = 0.5,
                    Imagem = "https://placehold.co/600x400",

                },
               new Trabalhos
               {
                   Id = 2,
                   Nome = "Glowing Mushroom",
                   Tipo = "Animação",
                   Descricao = "Animação, floresta, cogumelos, borboletas.",
                   Tamanho = 120,
                   SoftwareUsado = "Blender",
                   Duracao = 0.5,
                   Imagem = "https://placehold.co/600x401",

               },
               new Trabalhos
               {
                   Id = 3,
                   Nome = "Rigor Mortis",
                   Tipo = "Animação",
                   Descricao = "Animação morgue abandonada, luzes a piscar ambiente de terror.",
                   Tamanho = 80,
                   SoftwareUsado = "Blender",
                   Duracao = 0.5,
                   Imagem = "https://placehold.co/600x402",

               });
        }
    }
}
