namespace Joaoafonsosite.Domain.Entities
{
    public class Trabalhos
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Tipo { get; set; }
        public string? Descricao { get; set; }
        public double Tamanho { get; set; }
        public string? SoftwareUsado { get; set; }
        public double Duracao { get; set;}
        public string? Imagem { get; set; }
        public DateTime? DataDeCriacao { get; set; }
        public DateTime? DataDeEdicao { get; set; }
    }
}
