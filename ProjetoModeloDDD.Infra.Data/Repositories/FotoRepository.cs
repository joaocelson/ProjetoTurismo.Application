
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class FotoRepository : RepositoryBase<Foto>, IFotoRepository
    {
        public IEnumerable<Foto> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
