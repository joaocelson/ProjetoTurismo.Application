using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Chale : Estabelecimento
    {
        public int ChaleId { get; set; }

        public int NumeroQuartos { get; set; }

        public int NumeroVagasGaragem { get; set; }

        public int NumeroPessoas { get; set; }

        public Estabelecimento estabelecimento { get; set; }
    }


}
