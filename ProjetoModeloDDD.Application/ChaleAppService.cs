

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class ChaleAppService : AppServiceBase<Chale>, IChaleAppService
    {
        private readonly IChaleService _chaleService;

        public ChaleAppService(IChaleService chaleService)
            : base(chaleService)
        {
            _chaleService = chaleService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
