

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class TelefoneAppService : AppServiceBase<Telefone>, ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneAppService(ITelefoneService telefoneService)
            : base(telefoneService)
        {
            _telefoneService = telefoneService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
