using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;

namespace TurismoDDD.MVC.Controllers
{
    public class TipoEstabelecimentosController : Controller
    {
        // GET: Produtos
        private readonly ITipoEstabelecimentoAppService _estabelecimentoApp;

        public TipoEstabelecimentosController(ITipoEstabelecimentoAppService estabelecimentoApp)
        {
            _estabelecimentoApp = estabelecimentoApp;
        }
    }
}