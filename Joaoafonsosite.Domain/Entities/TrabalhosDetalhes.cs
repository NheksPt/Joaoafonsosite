using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joaoafonsosite.Domain.Entities
{
    public class TrabalhosDetalhes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Trabalhos_Detalhes { get; set; }

        [ForeignKey("Trabalhos")]
       
        public int TrabalhosId { get; set; }
        public Trabalhos? Trabalhos { get; set; } 
        public string? Materiais { get; set; }

        public string? Assets { get; set; }

    }
}
