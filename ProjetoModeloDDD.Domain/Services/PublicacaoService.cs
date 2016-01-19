
using System.Collections.Generic;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Repositories;
using TurismoDDD.Domain.Interfaces.Services;
namespace TurismoDDD.Domain.Services
{
    public class PublicacaoService : ServiceBase<Publicacao>, IPublicacaoService 
    {
        private readonly IPublicacaoRepository _publicacaoRepository;

        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
            : base(publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        //public IEnumerable<Estabelecimento> BuscarPorNome(string nome)
        //{
        //    return _casaRepository.BuscarPorNome(nome);
        //}
    }
}
