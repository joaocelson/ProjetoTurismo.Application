using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TurismoDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class PublicacaoViewModel
    {
        [Key]
        public int PublicacaoId { get; set; }

        public String Descricao { get; set; }

        public List<FotoViewModel> Fotos { get; set; }

        public UsuarioViewModel Usuario { get; set; }

        public List<CurtidaViewModel> Curtidas { get; set; }

        public DateTime DataInativacao { get; set; }

        public DateTime DataPublicacao { get; set; }
    }
}