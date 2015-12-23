using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Services
{
    public interface IEstabelecimentoService : IServiceBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> BuscarPorNome(string nome);
    }
}
