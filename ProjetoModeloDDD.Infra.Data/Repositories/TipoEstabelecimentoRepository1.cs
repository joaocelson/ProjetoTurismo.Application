
using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;

namespace TurismoDDD.Infra.Data.Repositories
{
    public class TipoEstabelecimentoRepository : RepositoryBase<TipoEstabelecimento>, ITipoEstabelecimentoRepository
    {
        public IEnumerable<TipoEstabelecimento> BuscarPorNome(string nome)
        {
            return null;
        }
    }
}
