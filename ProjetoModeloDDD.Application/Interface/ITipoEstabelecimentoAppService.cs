
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Application.Interface
{
    public interface ITipoEstabelecimentoAppService : IAppServiceBase<TipoEstabelecimento>
    {
        IEnumerable<TipoEstabelecimento> BuscarPorNome(string nome);
    }
}
