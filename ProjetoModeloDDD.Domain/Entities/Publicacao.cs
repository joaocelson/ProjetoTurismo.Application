using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Publicacao
    {
        public int PublicacaoId { get; set; }

        public String Descricao { get; set; }

        public List<Foto> Fotos { get; set; }

        public Usuario Usuario { get; set; }

        public List<Curtida> Curtidas { get; set; }

        public DateTime DataInativacao { get; set; }

        public DateTime DataPublicacao { get; set; }
    }
}
