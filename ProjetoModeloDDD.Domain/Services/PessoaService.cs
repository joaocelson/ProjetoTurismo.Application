

using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
            : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> ObterPessoasEspeciais(IEnumerable<Pessoa> pessoas)
        {
            return pessoas.Where(c => c.PessoaEspecial(c));
        }
    }
}
