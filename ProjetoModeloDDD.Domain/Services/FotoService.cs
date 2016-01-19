
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class FotoService : ServiceBase<Foto>, IFotoService 
    {
        private readonly IFotoRepository _fotoRepository;

        public FotoService(IFotoRepository fotoRepository)
            : base(fotoRepository)
        {
            _fotoRepository = fotoRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
