

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TurismoDDD.MVC.ViewModels
{
    public class TipoPessoaViewModel
    {
        [Key]
        public int TipoPessoaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descricao")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Descricao { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
    }
}