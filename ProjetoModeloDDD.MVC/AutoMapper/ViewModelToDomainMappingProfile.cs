
using AutoMapper;
using ProjetoModeloDDD.MVC.ViewModels;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;

namespace TurismoDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Casa, CasaViewModel>();
            Mapper.CreateMap<Chale, ChaleViewModel>();
            Mapper.CreateMap<Curtida, CurtidaViewModel>();
            Mapper.CreateMap<Estabelecimento, EstabelecimentoViewModel>();
            Mapper.CreateMap<Foto, FotoViewModel>();
            Mapper.CreateMap<PousadaHotel, PousadaHotelViewModel>();
            Mapper.CreateMap<Publicacao, PublicacaoViewModel>();
            Mapper.CreateMap<Telefone, TelefoneViewModel>();
            Mapper.CreateMap<TipoFoto, TipoFotoViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<TipoEstabelecimento, TipoEstabelecimentoViewModel>();
            Mapper.CreateMap<TipoUsuario, TipoUsuarioViewModel>();
        }
    }
}