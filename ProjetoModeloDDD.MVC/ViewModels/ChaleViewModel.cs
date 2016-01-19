using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TurismoDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ChaleViewModel: EstabelecimentoViewModel
    {
        [Key]
        public int ChaleId { get; set; }

        public int NumeroQuartos { get; set; }

        public int NumeroVagasGaragem { get; set; }

        public int NumeroPessoas { get; set; }

        public virtual EstabelecimentoViewModel estabelecimento { get; set; }
   
    }
}