
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class PousadaHotelService : ServiceBase<PousadaHotel>, IPousadaHotelService 
    {
        private readonly IPousadaHotelRepository _pousadaHotelRepository;

        public PousadaHotelService(IPousadaHotelRepository pousadaHotelRepository)
            : base(pousadaHotelRepository)
        {
            _pousadaHotelRepository = pousadaHotelRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
