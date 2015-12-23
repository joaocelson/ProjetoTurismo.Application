

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(IPessoaService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public IEnumerable<Pessoa> ObterPessoasEspeciais()
        {
            return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        }
    }
}
