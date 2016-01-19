

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _pessoaService;

        public UsuarioAppService(IUsuarioService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
