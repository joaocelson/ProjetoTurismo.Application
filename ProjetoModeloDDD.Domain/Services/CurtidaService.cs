
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class CurtidaService : ServiceBase<Curtida>, ICurtidaService 
    {
        private readonly ICurtidaRepository _curtidaRepository;

        public CurtidaService(ICurtidaRepository curtidaRepository)
            : base(curtidaRepository)
        {
            _curtidaRepository = curtidaRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
