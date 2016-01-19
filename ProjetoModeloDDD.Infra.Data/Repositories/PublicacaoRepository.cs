
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class PublicacaoRepository : RepositoryBase<Publicacao>, IPublicacaoRepository
    {
        public IEnumerable<Publicacao> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
