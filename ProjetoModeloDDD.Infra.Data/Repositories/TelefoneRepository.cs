
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class TelefoneRepository : RepositoryBase<Telefone>, ITelefoneRepository
    {
        public IEnumerable<Telefone> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
