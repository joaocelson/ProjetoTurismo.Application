
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Services
{
    public interface ITipoPessoaService : IServiceBase<TipoPessoa>
    {
        IEnumerable<TipoPessoa> ObterPessoasEspeciais(IEnumerable<TipoPessoa> pessoas);
    }
}
