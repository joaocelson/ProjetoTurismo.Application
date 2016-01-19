using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class TelefoneViewModel
    {
        [Key]
        public int TelefoneId { get; set; }

        public String NumeroTelefone { get; set; }

        public DateTime DataInativacao { get; set; }
    }
}