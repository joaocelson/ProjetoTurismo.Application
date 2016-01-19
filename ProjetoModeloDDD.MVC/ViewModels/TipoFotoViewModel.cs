using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class TipoFotoViewModel
    {
        [Key]
        public int TipoFotoId { get; set; }

        public String Descricao { get; set; }

        public DateTime DataInativacao { get; set; }
    }
}