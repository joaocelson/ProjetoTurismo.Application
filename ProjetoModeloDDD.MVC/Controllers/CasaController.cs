using AutoMapper;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class CasaController : Controller
    {
        private readonly IEstabelecimentoAppService _estabelecimentoApp;
        private readonly ICasaAppService _casaApp;

        public CasaController(IEstabelecimentoAppService estabelecimentoApp, ICasaAppService casaApp)
        {
            _estabelecimentoApp = estabelecimentoApp;
            _casaApp = casaApp;
        }
        
        //
        // GET: /Casa/
        public ActionResult Index()
        {
            var casaViewModel = Mapper.Map<IEnumerable<Casa>, IEnumerable<CasaViewModel>>(_casaApp.GetAll());

            return View(casaViewModel);
        }

        //
        // GET: /Casa/Details/5
        public ActionResult Details(int id)
        {
            var casa = _casaApp.GetById(id);
            var casaViewModel = Mapper.Map<Casa, CasaViewModel>(casa);

            return View(casaViewModel);
        }

        //
        // GET: /Casa/Create
        public ActionResult Create()
        {
            //ViewBag.UsuarioId = new SelectList(_usuarios.GetAll(), "PessoaId", "Nome");
            return View();
        }

        //
        // POST: /Casa/Create
        [HttpPost]
        public ActionResult Create(CasaViewModel casaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var casaDomain = Mapper.Map<CasaViewModel, Casa>(casaViewModel);
                    _casaApp.Add(casaDomain);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var casa = _casaApp.GetById(id);
            var casaViewModel = Mapper.Map<Casa, CasaViewModel>(casa);

            return View(casaViewModel);
        }

        //
        // POST: /Casa/Edit/5
        [HttpPost]
        public ActionResult Edit(CasaViewModel casaParam)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var casaDomain = Mapper.Map<CasaViewModel, Casa>(casaParam);
                    _casaApp.Update(casaDomain);

                    return RedirectToAction("Index");
                }
                return View(casaParam);
            }
            catch
            {
                return View();
            }
        }
                
        //
        // POST: /Casa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var casaDomain = _casaApp.GetById(id);
                var casaViewModel = Mapper.Map<Casa, CasaViewModel>(casaDomain);

                return View(casaViewModel);
            }
            catch
            {
                return View();
            }
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var casa = _casaApp.GetById(id);
            _casaApp.Remove(casa);

            return RedirectToAction("Index");
        }
    }
}
