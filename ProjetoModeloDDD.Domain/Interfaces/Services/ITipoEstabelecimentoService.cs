using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Services
{
    public interface ITipoEstabelecimentoService : IServiceBase<TipoEstabelecimento>
    {
        IEnumerable<TipoEstabelecimento> BuscarPorNome(string nome);
    }
}
