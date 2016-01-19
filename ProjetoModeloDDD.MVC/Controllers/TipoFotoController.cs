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
    public class TipoFotoController : Controller
    {
         private readonly ITipoFotoAppService _tipoFotoApp;

         public TipoFotoController(ITipoFotoAppService tipoFotoApp)
        {
            _tipoFotoApp = tipoFotoApp;
        }
        //
        // GET: /TipoFoto/
        public ActionResult Index()
        {
            var tipoFotoViewModel = Mapper.Map<IEnumerable<TipoFoto>, IEnumerable<TipoFotoViewModel>>(_tipoFotoApp.GetAll());

            return View(tipoFotoViewModel);
        }

        //
        // GET: /TipoFoto/Details/5
        public ActionResult Details(int id)
        {
            var tipoFoto = _tipoFotoApp.GetById(id);
            var tipoFotoViewModel = Mapper.Map<TipoFoto, TipoFotoViewModel>(tipoFoto);

            return View(tipoFotoViewModel);
        }

        //
        // GET: /TipoFoto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoFoto/Create
        [HttpPost]
        public ActionResult Create(TipoFotoViewModel tipoFotoViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var tipoFotoDomain = Mapper.Map<TipoFotoViewModel, TipoFoto>(tipoFotoViewModel);
                    _tipoFotoApp.Add(tipoFotoDomain);
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
            var tipoFoto = _tipoFotoApp.GetById(id);
            var tipoFotoViewModel = Mapper.Map<TipoFoto, TipoFotoViewModel>(tipoFoto);

            return View(tipoFotoViewModel);
        }

        //
        // POST: /TipoFoto/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoFotoViewModel tipoFotoParam)
        {
            try
            {
                // TODO: Add update logic here

                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var tipoFotoDomain = Mapper.Map<TipoFotoViewModel, TipoFoto>(tipoFotoParam);
                    _tipoFotoApp.Update(tipoFotoDomain);

                    return RedirectToAction("Index");
                }
                return View(tipoFotoParam);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /TipoFoto/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoFoto = _tipoFotoApp.GetById(id);
            var tipoFotoViewModel = Mapper.Map<TipoFoto, TipoFotoViewModel>(tipoFoto);

            return View(tipoFotoViewModel);
        }

        //
        // POST: /TipoFoto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
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
            var tipoFoto = _tipoFotoApp.GetById(id);
            _tipoFotoApp.Remove(tipoFoto);

            return RedirectToAction("Index");
        }
    }
}
