using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;

namespace TurismoDDD.MVC.Controllers
{
    public class TipoUsuarioController : Controller
    {
        private readonly ITipoUsuarioAppService _tipoPessoaApp;

        public TipoUsuarioController(ITipoUsuarioAppService tipoPessoaApp)
        {
            _tipoPessoaApp = tipoPessoaApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<TipoUsuario>, IEnumerable<TipoUsuarioViewModel>>(_tipoPessoaApp.GetAll());
            return View(pessoaViewModel);
        }

        public ActionResult Especiais()
        {
            var tipoPessoaViewModel = Mapper.Map<IEnumerable<TipoUsuario>, IEnumerable<TipoUsuarioViewModel>>(_tipoPessoaApp.ObterPessoasEspeciais());

            return View(tipoPessoaViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            var tipoPessoaViewModel = Mapper.Map<TipoUsuario, TipoUsuarioViewModel>(tipoPessoa);

            return View(tipoPessoaViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoUsuarioViewModel tipoPessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<TipoUsuarioViewModel, TipoUsuario>(tipoPessoa);
                _tipoPessoaApp.Add(pessoaDomain);

                return RedirectToAction("Index");
            }

            return View(tipoPessoa);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            var tipoPessoaViewModel = Mapper.Map<TipoUsuario, TipoUsuarioViewModel>(tipoPessoa);

            return View(tipoPessoaViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoUsuarioViewModel tipoPessoa)
        {
            if (ModelState.IsValid)
            {
                var tipoPessoaDomain = Mapper.Map<TipoUsuarioViewModel, TipoUsuario>(tipoPessoa);
                _tipoPessoaApp.Update(tipoPessoaDomain);

                return RedirectToAction("Index");
            }

            return View(tipoPessoa);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            var tipoPessoaViewModel = Mapper.Map<TipoUsuario, TipoUsuarioViewModel>(tipoPessoa);

            return View(tipoPessoaViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var tipoPessoa = _tipoPessoaApp.GetById(id);
            _tipoPessoaApp.Remove(tipoPessoa);

            return RedirectToAction("Index");
        }
    }
}
