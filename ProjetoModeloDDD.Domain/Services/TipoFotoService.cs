
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class TipoFotoService : ServiceBase<TipoFoto>, ITipoFotoService 
    {
        private readonly ITipoFotoRepository _tipoFotoRepository;

        public TipoFotoService(ITipoFotoRepository tipoFotoRepository)
            : base(tipoFotoRepository)
        {
            _tipoFotoRepository = tipoFotoRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
