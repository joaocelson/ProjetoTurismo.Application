using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TurismoDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class PousadaHotelViewModel : EstabelecimentoViewModel
    {
        [Key]
        public int PousadaHotelId { get; set; }

        public int NumeroQuartos { get; set; }

        public int NumeroVagasGaragem { get; set; }

        public int NumeroPessoas { get; set; }

        public EstabelecimentoViewModel EstabelecimentoViewModel { get; set; }

    }
}