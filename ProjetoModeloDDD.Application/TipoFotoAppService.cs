

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class TipoFotoAppService : AppServiceBase<TipoFoto>, ITipoFotoAppService
    {
        private readonly ITipoFotoService _tipoFotoService;

        public TipoFotoAppService(ITipoFotoService tipoFotoService)
            : base(tipoFotoService)
        {
            _tipoFotoService = tipoFotoService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
