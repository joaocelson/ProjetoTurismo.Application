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
    public class CurtidaController : Controller
    {
        private readonly ICurtidaAppService _curtidaApp;

        public CurtidaController(ICurtidaAppService curtidaParam)
        {
            _curtidaApp = curtidaParam;
        }

        //
        // GET: /Curtida/
        public ActionResult Index()
        {
            var curtidaViewModel = Mapper.Map<IEnumerable<Curtida>, IEnumerable<CurtidaViewModel>>(_curtidaApp.GetAll());
            return View(curtidaViewModel);
        }

        //
        // GET: /Curtida/Details/5
        public ActionResult Details(int id)
        {
            var curtida = _curtidaApp.GetById(id);
            var curtidaViewModel = Mapper.Map<Curtida, CurtidaViewModel>(curtida);

            return View(curtidaViewModel);
        }

        //
        // GET: /Curtida/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Curtida/Create
        [HttpPost]
        public ActionResult Create(CurtidaViewModel curtidaViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var curtidaDomain = Mapper.Map<CurtidaViewModel, Curtida>(curtidaViewModel);
                    _curtidaApp.Add(curtidaDomain);
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
            var curtida = _curtidaApp.GetById(id);
            var curtidaViewModel = Mapper.Map<Curtida, CurtidaViewModel>(curtida);

            return View(curtidaViewModel);
        }

        //
        // POST: /Curtida/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CurtidaViewModel curtidaParam)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var curtidaDomain = Mapper.Map<CurtidaViewModel, Curtida>(curtidaParam);
                    _curtidaApp.Update(curtidaDomain);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Curtida/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var curtidaDomain = _curtidaApp.GetById(id);
                var curtidaViewModel = Mapper.Map<Curtida, CurtidaViewModel>(curtidaDomain);

                return View(curtidaViewModel);
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
            var curtida = _curtidaApp.GetById(id);
            _curtidaApp.Remove(curtida);

            return RedirectToAction("Index");
        }
    }
}
