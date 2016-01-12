
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TurismoDDD.MVC.ViewModels
{
    public class TipoEstabelecimentoViewModel
    {
        [Key]
        public int TipoEstabelecimentoId { get; set; }

        [DisplayName("Descrição")]
        public bool Disponivel { get; set; }
        
        public virtual EstabelecimentoViewModel Estabelecimento { get; set; }
    }
}