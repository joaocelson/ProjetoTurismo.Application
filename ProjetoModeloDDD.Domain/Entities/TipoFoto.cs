using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class TipoFoto
    {
        public int TipoFotoId { get; set; }

        public String Descricao { get; set; }

        public DateTime DataInativacao { get; set; }
    }
}
