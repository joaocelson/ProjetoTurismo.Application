
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TurismoDDD.MVC.ViewModels
{
    public class EstabelecimentoViewModel
    {
        [Key]
        public int EstabelecimentoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string NomeFotoPerfil { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
        public int PessoaId { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

       // public virtual PessoaViewModel Pessoa { get; set; }
    }
}