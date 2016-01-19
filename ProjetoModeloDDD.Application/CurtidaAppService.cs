

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class CasaAppService : AppServiceBase<Casa>, ICasaAppService
    {
        private readonly ICasaService _casaService;

        public CasaAppService(ICasaService casaService)
            : base(casaService)
        {
            _casaService = casaService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
