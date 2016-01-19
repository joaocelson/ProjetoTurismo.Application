using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Curtida
    {
        public int CurtidaId { get; set; }

        public Usuario Usuario { get; set; }

        public Publicacao Publicacao { get; set; }

        public DateTime DataInativacao { get; set; }

        public DateTime DataCurtida { get; set; }
    }
}
