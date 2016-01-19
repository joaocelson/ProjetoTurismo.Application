using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Casa : Estabelecimento
    {
        public int CasaId;

        public int NumeroQuartos;

        public int Suites;

        public int NumeroSalas;

        public int NumeroBanheiros;

        public int NumeroPessoas;

        public int NumeroVagasGaragem;

        public Estabelecimento estabelecimento;

    }

}
