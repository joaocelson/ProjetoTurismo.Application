

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class PublicacaoAppService : AppServiceBase<Publicacao>, IPublicacaoAppService
    {
        private readonly IPublicacaoService _publicacaoService;

        public PublicacaoAppService(IPublicacaoService publicacaoService)
            : base(publicacaoService)
        {
            _publicacaoService = publicacaoService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
