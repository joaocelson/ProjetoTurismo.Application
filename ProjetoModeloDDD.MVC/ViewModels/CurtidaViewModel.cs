using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TurismoDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class CurtidaViewModel
    {
        [Key]
        public int CurtidaId { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        public PublicacaoViewModel Publicacao { get; set; }

        public DateTime DataInativacao { get; set; }

        public DateTime DataCurtida { get; set; }
    }
}