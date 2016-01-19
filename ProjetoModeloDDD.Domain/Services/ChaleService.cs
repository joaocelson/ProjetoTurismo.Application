
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class ChaleService : ServiceBase<Chale>, IChaleService 
    {
        private readonly IChaleRepository _chaleRepository;

        public ChaleService(IChaleRepository chaleRepository)
            : base(chaleRepository)
        {
            _chaleRepository = chaleRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
