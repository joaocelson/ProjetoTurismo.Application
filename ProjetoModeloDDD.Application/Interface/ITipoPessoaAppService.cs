
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Application.Interface
{
    public interface ITipoPessoaAppService : IAppServiceBase<TipoPessoa>
    {
        IEnumerable<TipoPessoa> ObterPessoasEspeciais();
    }
}
