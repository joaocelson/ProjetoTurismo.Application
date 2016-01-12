
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class EstabelecimentoRepository : RepositoryBase<Estabelecimento>, IEstabelecimentoRepository
    {
        public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
