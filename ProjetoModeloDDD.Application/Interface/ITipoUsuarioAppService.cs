
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Application.Interface
{
    public interface ITipoUsuarioAppService : IAppServiceBase<TipoUsuario>
    {
        IEnumerable<TipoUsuario> ObterPessoasEspeciais();
    }
}
