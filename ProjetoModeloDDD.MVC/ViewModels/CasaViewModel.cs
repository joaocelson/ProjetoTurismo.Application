using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TurismoDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class CasaViewModel : EstabelecimentoViewModel
    {
        [Key]
        public int CasaId { get; set; }

        public int NumeroQuartos { get; set; }

        public int Suites { get; set; }

        public int NumeroSalas { get; set; }

        public int NumeroBanheiros { get; set; }

        public int NumeroPessoas { get; set; }

        public int NumeroVagasGaragem { get; set; }

        public EstabelecimentoViewModel EstabelecimentoViewModel { get; set; }
    }
}