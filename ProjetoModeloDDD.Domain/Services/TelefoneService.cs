
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService 
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository)
            : base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
