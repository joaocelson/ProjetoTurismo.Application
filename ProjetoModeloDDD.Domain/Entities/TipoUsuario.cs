using System;
using System.Collections.Generic;

namespace TurismoDDD.Domain.Entities
{
    public class TipoUsuario
    {
        public int TipoUsuarioId { get; set; }
        
        public String Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
