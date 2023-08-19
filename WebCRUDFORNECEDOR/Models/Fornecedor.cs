using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDFORNECEDOR.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column]
        [Display(Name = "id")]
        public int id { get; set; }

        [Column]
        [Display(Name ="Nome")]
        public string nome { get; set; }

        [Column]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Column]
        [Display(Name = "Especialidade")]
        public string especialidade { get; set; }

        [Column]
        [Display(Name = "Endereco")]
        public string endereco { get; set; }
    }
}
