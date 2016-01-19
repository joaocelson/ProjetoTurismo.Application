
using AutoMapper;
using ProjetoModeloDDD.MVC.ViewModels;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;

namespace TurismoDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CasaViewModel, Casa>();
            Mapper.CreateMap<ChaleViewModel, Chale>();
            Mapper.CreateMap<CurtidaViewModel, Curtida>();
            Mapper.CreateMap<EstabelecimentoViewModel, Estabelecimento>();
            Mapper.CreateMap<FotoViewModel, Foto>();
            Mapper.CreateMap<PousadaHotelViewModel, PousadaHotel>();
            Mapper.CreateMap<PublicacaoViewModel, Publicacao>();
            Mapper.CreateMap<TelefoneViewModel, Telefone>();
            Mapper.CreateMap<TipoFotoViewModel, TipoFoto>();
            Mapper.CreateMap<TipoEstabelecimentoViewModel, TipoEstabelecimento>();
            Mapper.CreateMap<TipoUsuarioViewModel, TipoUsuario>();
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
        }
    }
}