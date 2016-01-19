

using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Domain.Services
{
    public class TipoUsuarioService : ServiceBase<TipoUsuario>, ITipoUsuarioService
    {
        private readonly ITipoUsuarioRepository _tipoPessoaRepository;

        public TipoUsuarioService(ITipoUsuarioRepository pessoaRepository)
            : base(pessoaRepository)
        {
            _tipoPessoaRepository = pessoaRepository;
        }
        
        public IEnumerable<TipoUsuario> ObterPessoasEspeciais(IEnumerable<TipoUsuario> pessoas)
        {
            return pessoas;
        }
    }
}
