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
    public class FotoController : Controller
    {
        private readonly IFotoAppService _fotoApp;

        public FotoController(IFotoAppService fotoAppParam)
        {
            _fotoApp = fotoAppParam;
        }
        //
        // GET: /Foto/
        public ActionResult Index()
        {
            var fotoViewModel = Mapper.Map<IEnumerable<Foto>, IEnumerable<FotoViewModel>>(_fotoApp.GetAll());
            return View(fotoViewModel);
        }

        //
        // GET: /Foto/Details/5
        public ActionResult Details(int id)
        {
            var foto = _fotoApp.GetById(id);
            var fotoViewModel = Mapper.Map<Foto, FotoViewModel>(foto);

            return View(fotoViewModel);
        }

        //
        // GET: /Foto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Foto/Create
        [HttpPost]
        public ActionResult Create(FotoViewModel fotoParam)
        {
            try
            {
                // TODO: Add insert logic here

                if (ModelState.IsValid)
                {
                    var fotoDomain = Mapper.Map<FotoViewModel, Foto>(fotoParam);
                    _fotoApp.Add(fotoDomain);
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
            var foto = _fotoApp.GetById(id);
            var fotoViewModel = Mapper.Map<Foto, FotoViewModel>(foto);

            return View(fotoViewModel);
        }

        //
        // POST: /Foto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FotoViewModel fotoParam)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var fotoDomain = Mapper.Map<FotoViewModel, Foto>(fotoParam);
                    _fotoApp.Update(fotoDomain);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Foto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var fotoDomain = _fotoApp.GetById(id);
                var fotoViewModel = Mapper.Map<Foto, FotoViewModel>(fotoDomain);
                return View(fotoViewModel);
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
            var foto = _fotoApp.GetById(id);
            _fotoApp.Remove(foto);

            return RedirectToAction("Index");
        }
    }
}
