using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.ControllersWebAPI
{
    public class PessoasWebController : ApiController
    {
        private readonly IPessoaAppService _pessoaApp;

        public PessoasWebController(IPessoaAppService pessoaApp)
        {
            _pessoaApp = pessoaApp;
        }

        public String Get()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaApp.GetAll());
            return pessoaViewModel.ToString();
        }
    }
}
