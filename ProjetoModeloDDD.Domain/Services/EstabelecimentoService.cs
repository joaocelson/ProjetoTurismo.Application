
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Domain.Services
{
    public class EstabelecimentoService : ServiceBase<Estabelecimento>, IEstabelecimentoService
    {
        private readonly IEstabelecimentoRepository _estabelecimentoRepository;

        public EstabelecimentoService(IEstabelecimentoRepository estabelecimentoRepository)
            : base(estabelecimentoRepository)
        {
            _estabelecimentoRepository = estabelecimentoRepository;
        }

        public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        {
            return _estabelecimentoRepository.BuscarPorNome(nome);
        }
    }
}
