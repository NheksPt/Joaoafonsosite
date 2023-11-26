using System.ComponentModel.DataAnnotations;

namespace Joaoafonsosite.Domain.Entities
{
    public class Trabalhos
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Tipo { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }
        [Display(Name = "Tamanho em MB")]
        public double Tamanho { get; set; }
        [Display(Name ="Software Usado")]
        public string? SoftwareUsado { get; set; }
        [Display(Name = "Duração em segundos")]
        public double Duracao { get; set;}
        public string? Imagem { get; set; }
        public DateTime? DataDeCriacao { get; set; }
        public DateTime? DataDeEdicao { get; set; }
    }
}
