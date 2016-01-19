
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Domain.Services
{
    public class TipoEstabelecimentoService : ServiceBase<TipoEstabelecimento>, ITipoEstabelecimentoService
    {
        private readonly ITipoEstabelecimentoRepository _estabelecimentoRepository;

        public TipoEstabelecimentoService(ITipoEstabelecimentoRepository estabelecimentoRepository)
            : base(estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }

        public IEnumerable<TipoEstabelecimento> BuscarPorNome(string nome)
        {
            return _estabelecimentoRepository.BuscarPorNome(nome);
        }
    }
}
