using System;
using System.Collections.Generic;

namespace TurismoDDD.Domain.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<Estabelecimento> Estabelecimentos { get; set; }

        public bool PessoaEspecial(Pessoa pessoa)
        {
            return pessoa.Ativo && DateTime.Now.Year - pessoa.DataCadastro.Year >= 5;
        }
    }
}
