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
    public class ChalesController : Controller
    {

        private readonly IEstabelecimentoAppService _estabelecimentoApp;
        private readonly IChaleAppService _chaleApp;

        public ChalesController(IEstabelecimentoAppService estabelecimentoAppParam, IChaleAppService chaleAppParam)
        {
            _estabelecimentoApp = estabelecimentoAppParam;
            _chaleApp = chaleAppParam;
        }

        //
        // GET: /Chales/
        public ActionResult Index()
        {
            var chaleViewModel = Mapper.Map<IEnumerable<Chale>, IEnumerable<ChaleViewModel>>(_chaleApp.GetAll());
            return View(chaleViewModel);
        }

        //
        // GET: /Chales/Details/5
        public ActionResult Details(int id)
        {
            var chale = _chaleApp.GetById(id);
            var chaleViewModel = Mapper.Map<Chale, ChaleViewModel>(chale);

            return View(chaleViewModel);
        }

        //
        // GET: /Chales/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Chales/Create
        [HttpPost]
        public ActionResult Create(ChaleViewModel chaleViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var chaleDomain = Mapper.Map<ChaleViewModel, Chale>(chaleViewModel);
                    _chaleApp.Add(chaleDomain);
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
            var chale = _chaleApp.GetById(id);
            var chaleViewModel = Mapper.Map<Chale, ChaleViewModel>(chale);

            return View(chaleViewModel);
        }

        //
        // POST: /Chales/Edit/5
        [HttpPost]
        public ActionResult Edit(ChaleViewModel chaleParam)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var chaleDomain = Mapper.Map<ChaleViewModel, Chale>(chaleParam);
                    _chaleApp.Update(chaleDomain);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        //
        // POST: /Chales/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here

                var chaleDomain = _chaleApp.GetById(id);
                var chaleViewModel = Mapper.Map<Chale, ChaleViewModel>(chaleDomain);

                return View(chaleViewModel);
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
            var chale = _chaleApp.GetById(id);
            _chaleApp.Remove(chale);

            return RedirectToAction("Index");
        }
    }
}
