using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Repositories
{
    public interface ITipoEstabelecimentoRepository : IRepositoryBase<TipoEstabelecimento>
    {
        IEnumerable<TipoEstabelecimento> BuscarPorNome(string nome);
    }
}
