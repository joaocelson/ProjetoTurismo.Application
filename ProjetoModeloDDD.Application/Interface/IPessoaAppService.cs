
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Application.Interface
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> ObterPessoasEspeciais();
    }
}
