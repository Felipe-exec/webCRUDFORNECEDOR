﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDFORNECEDOR.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Display(Name = "id")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
        public string nome { get; set; }

        [Display(Name = "CNPJ")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve conter exatamente 14 dígitos numéricos.")]
        public long cnpj { get; set; } // problemas com *int, movido para *long

        [Display(Name = "Especialidade")]
        public string especialidade { get; set; }

        [Display(Name = "CEP")]
        [RegularExpression(@"^\d{1,8}$", ErrorMessage = "O CEP deve conter no máximo 8 dígitos.")]
        public int cep { get; set; }

        [Display(Name = "Endereço")]
        [StringLength(255, ErrorMessage = "O endereço não pode ter mais de 255 caracteres.")]
        public string endereco { get; set; }
    }
}
