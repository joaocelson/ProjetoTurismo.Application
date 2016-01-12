
using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class TipoEstabelecimentoAppService : AppServiceBase<TipoEstabelecimento>, ITipoEstabelecimentoAppService
    {
        private readonly ITipoEstabelecimentoService _estabelecimentoService;

        public TipoEstabelecimentoAppService(ITipoEstabelecimentoService estabelecimentoService)
            : base(estabelecimentoService)
        {
            _estabelecimentoService = estabelecimentoService;
        }

        public IEnumerable<TipoEstabelecimento> BuscarPorNome(string nome)
        {
            return _estabelecimentoService.BuscarPorNome(nome);
        }
    }
}
