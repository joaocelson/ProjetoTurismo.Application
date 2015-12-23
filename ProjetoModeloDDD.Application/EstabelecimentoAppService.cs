
using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class EstabelecimentoAppService : AppServiceBase<Estabelecimento>, IEstabelecimentoAppService
    {
        private readonly IEstabelecimentoService _estabelecimentoService;

        public EstabelecimentoAppService(IEstabelecimentoService estabelecimentoService)
            : base(estabelecimentoService)
        {
            _estabelecimentoService = estabelecimentoService;
        }

        public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        {
            return _estabelecimentoService.BuscarPorNome(nome);
        }
    }
}
