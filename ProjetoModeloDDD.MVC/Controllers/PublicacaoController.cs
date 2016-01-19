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
    public class PublicacaoController : Controller
    {

        private readonly IPublicacaoAppService _publicacaoApp;

        public PublicacaoController(IPublicacaoAppService publicacaoApp)
        {
            _publicacaoApp = publicacaoApp;
        }
        //
        // GET: /Publicacao/
        public ActionResult Index()
        {
            var publicacaoViewModel = Mapper.Map<IEnumerable<Publicacao>, IEnumerable<PublicacaoViewModel>>(_publicacaoApp.GetAll());

            return View(publicacaoViewModel);
        }

        //
        // GET: /Publicacao/Details/5
        public ActionResult Details(int id)
        {
            var publicacao = _publicacaoApp.GetById(id);
            var publicacaoViewModel = Mapper.Map<Publicacao, PublicacaoViewModel>(publicacao);

            return View(publicacaoViewModel);
        }

        //
        // GET: /Publicacao/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Publicacao/Create
        [HttpPost]
        public ActionResult Create(PublicacaoViewModel publicacaoViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var publicacaoDomain = Mapper.Map<PublicacaoViewModel, Publicacao>(publicacaoViewModel);
                    _publicacaoApp.Add(publicacaoDomain);
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
            var publicacao = _publicacaoApp.GetById(id);
            var publicacaoViewModel = Mapper.Map<Publicacao, PublicacaoViewModel>(publicacao);

            return View(publicacaoViewModel);
        }

        //
        // POST: /Publicacao/Edit/5
        [HttpPost]
        public ActionResult Edit(PublicacaoViewModel publicacaoViewModel)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var publicacaoDomain = Mapper.Map<PublicacaoViewModel, Publicacao>(publicacaoViewModel);
                    _publicacaoApp.Update(publicacaoDomain);
                } 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Publicacao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var publicacaoDomain = _publicacaoApp.GetById(id);
                var publicacaoViewModel = Mapper.Map<Publicacao, PublicacaoViewModel>(publicacaoDomain);

                return View(publicacaoViewModel);
            }
            catch
            {
                return View();
            }
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var publicacao = _publicacaoApp.GetById(id);
            _publicacaoApp.Remove(publicacao);

            return RedirectToAction("Index");
        }
    }
}
