using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Casa : Estabelecimento
    {
        public int CasaId { get; set; }

        public int NumeroQuartos { get; set; }

        public int Suites { get; set; }

        public int NumeroSalas { get; set; }

        public int NumeroBanheiros { get; set; }

        public int NumeroPessoas { get; set; }

        public int NumeroVagasGaragem { get; set; }

        public Estabelecimento estabelecimento { get; set; }
    }

}
