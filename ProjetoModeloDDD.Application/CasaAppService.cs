

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class CurtidaAppService : AppServiceBase<Curtida>, ICurtidaAppService
    {
        private readonly ICurtidaService _curtidaService;

        public CurtidaAppService(ICurtidaService curtidaService)
            : base(curtidaService)
        {
            _curtidaService = curtidaService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
