
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class CasaService : ServiceBase<Casa>, ICasaService
    {
        private readonly ICasaRepository _casaRepository;

        public CasaService(ICasaRepository casaRepository)
            : base(casaRepository)
        {
            _casaRepository = casaRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
