using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Telefone
    {
        public int TelefoneId { get; set; }

        public String NumeroTelefone { get; set; }

        public DateTime DataInativacao { get; set; }
    }
}
