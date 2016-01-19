
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class ChaleRepository : RepositoryBase<Chale>, IChaleRepository
    {
        public IEnumerable<Chale> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
