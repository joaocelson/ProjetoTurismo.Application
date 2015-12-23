
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Services
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> ObterPessoasEspeciais(IEnumerable<Pessoa> pessoas);
    }
}
