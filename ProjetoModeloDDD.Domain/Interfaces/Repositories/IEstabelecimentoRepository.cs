using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Repositories
{
    public interface IEstabelecimentoRepository : IRepositoryBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> BuscarPorNome(string nome);
    }
}
