using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class FotoViewModel
    {
        [Key]
        public int FotoId { get; set; }

        public int NomeFoto { get; set; }

        public TipoFotoViewModel TipoFotoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataInativacao { get; set; }
    }
}