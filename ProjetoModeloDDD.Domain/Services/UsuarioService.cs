

using System.Collections.Generic;
using System.Linq;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _pessoaRepository;

        public UsuarioService(IUsuarioRepository pessoaRepository)
            : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais(IEnumerable<Usuario> pessoas)
        //{
        //    return pessoas.Where(c => c.PessoaEspecial(c));
        //}
    }
}
