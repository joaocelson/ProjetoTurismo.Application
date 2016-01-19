

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class TipoUsuarioAppService : AppServiceBase<TipoUsuario>, ITipoUsuarioAppService
    {
        private readonly ITipoUsuarioService _pessoaService;

        public TipoUsuarioAppService(ITipoUsuarioService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public IEnumerable<TipoUsuario> ObterPessoasEspeciais()
        {
            return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        }
    }
}
