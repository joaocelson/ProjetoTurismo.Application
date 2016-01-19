
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class CasaRepository : RepositoryBase<Casa>, ICasaRepository
    {
        public IEnumerable<Casa> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
