
using AutoMapper;
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
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Estabelecimento, EstabelecimentoViewModel>();
            Mapper.CreateMap<TipoEstabelecimento, TipoEstabelecimentoViewModel>();
            Mapper.CreateMap<TipoUsuario, TipoUsuarioViewModel>();
        }
    }
}