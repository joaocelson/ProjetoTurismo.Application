

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class FotoAppService : AppServiceBase<Foto>, IFotoAppService
    {
        private readonly IFotoService _fotoService;

        public FotoAppService(IFotoService fotoService)
            : base(fotoService)
        {
            _fotoService = fotoService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
