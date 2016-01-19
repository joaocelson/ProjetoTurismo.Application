﻿
using AutoMapper;
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
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<EstabelecimentoViewModel, Estabelecimento>();
            Mapper.CreateMap<TipoEstabelecimentoViewModel, TipoEstabelecimento>();
            Mapper.CreateMap<TipoUsuarioViewModel, TipoUsuario>();
        }
    }
}