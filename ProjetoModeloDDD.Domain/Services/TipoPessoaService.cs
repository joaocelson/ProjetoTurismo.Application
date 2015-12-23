

using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Domain.Services
{
    public class TipoPessoaService : ServiceBase<TipoPessoa>, ITipoPessoaService
    {
        private readonly ITipoPessoaRepository _tipoPessoaRepository;

        public TipoPessoaService(ITipoPessoaRepository pessoaRepository)
            : base(pessoaRepository)
        {
            _tipoPessoaRepository = pessoaRepository;
        }
        
        public IEnumerable<TipoPessoa> ObterPessoasEspeciais(IEnumerable<TipoPessoa> pessoas)
        {
            return pessoas;
        }
    }
}
