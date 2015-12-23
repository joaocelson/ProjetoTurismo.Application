using System;
using System.Collections.Generic;

namespace TurismoDDD.Domain.Entities
{
    public class TipoPessoa
    {
        public int TipoPessoaId { get; set; }
        
        public String Descricao { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
