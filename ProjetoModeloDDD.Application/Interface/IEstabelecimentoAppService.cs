
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Application.Interface
{
    public interface IEstabelecimentoAppService : IAppServiceBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> BuscarPorNome(string nome);
    }
}
