using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoDDD.Domain.Entities
{
    public class Foto
    {

        public int FotoId { get; set; }

        public int NomeFoto { get; set; }

        public TipoFoto TipoFotoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataInativacao { get; set; }
    }
}
