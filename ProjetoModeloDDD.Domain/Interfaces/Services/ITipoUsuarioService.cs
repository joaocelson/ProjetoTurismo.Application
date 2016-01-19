
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;

namespace TurismoDDD.Domain.Interfaces.Services
{
    public interface ITipoUsuarioService : IServiceBase<TipoUsuario>
    {
        IEnumerable<TipoUsuario> ObterPessoasEspeciais(IEnumerable<TipoUsuario> pessoas);
    }
}
