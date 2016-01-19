

using System.Collections.Generic;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.Domain.Interfaces.Services;

namespace TurismoDDD.Application
{
    public class PousadaHotelAppService : AppServiceBase<PousadaHotel>, IPousadaHotelAppService
    {
        private readonly IPousadaHotelService _pousadaHotelService;

        public PousadaHotelAppService(IPousadaHotelService pousadaHotelService)
            : base(pousadaHotelService)
        {
            _pousadaHotelService = pousadaHotelService;
        }

        //public IEnumerable<Usuario> ObterPessoasEspeciais()
        //{
        //    return _pessoaService.ObterPessoasEspeciais(_pessoaService.GetAll());
        //}
    }
}
