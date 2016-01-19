
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class PousadaHotelRepository : RepositoryBase<PousadaHotel>, IPousadaHotelRepository
    {
        public IEnumerable<PousadaHotel> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
