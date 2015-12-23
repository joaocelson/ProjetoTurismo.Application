

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class TipoPessoaAppService : AppServiceBase<TipoPessoa>, ITipoPessoaAppService
    {
        private readonly ITipoPessoaService _pessoaService;

        public TipoPessoaAppService(ITipoPessoaService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public IEnumerable<TipoPessoa> ObterPessoasEspeciais()
        {
            return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        }
    }
}
