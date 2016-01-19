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
    public class PousadaHotelController : Controller
    {
        private readonly IPousadaHotelAppService _pousadaHotelApp;

        public PousadaHotelController(IPousadaHotelAppService pousadaHotelApp)
        {
            _pousadaHotelApp = pousadaHotelApp;
        }

        //
        // GET: /PousadaHotel/
        public ActionResult Index()
        {
            var pousadaViewModel = Mapper.Map<IEnumerable<PousadaHotel>, IEnumerable<PousadaHotelViewModel>>(_pousadaHotelApp.GetAll());

            return View(pousadaViewModel);
        }

        //
        // GET: /PousadaHotel/Details/5
        public ActionResult Details(int id)
        {
            var pousadaHotel = _pousadaHotelApp.GetById(id);
            var pousadaViewModel = Mapper.Map<PousadaHotel, PousadaHotelViewModel>(pousadaHotel);

            return View(pousadaViewModel);
        }

        //
        // GET: /PousadaHotel/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PousadaHotel/Create
        [HttpPost]
        public ActionResult Create(PousadaHotelViewModel pousadaHotel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pousadaHotelDomain = Mapper.Map<PousadaHotelViewModel, PousadaHotel>(pousadaHotel);
                    _pousadaHotelApp.Add(pousadaHotelDomain);
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
            var pousadaHotel = _pousadaHotelApp.GetById(id);
            var pousadaHotelViewModel = Mapper.Map<PousadaHotel, PousadaHotelViewModel>(pousadaHotel);

            return View(pousadaHotelViewModel);
        }

        //
        // POST: /PousadaHotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PousadaHotelViewModel pousada)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var pousadaDomain = Mapper.Map<PousadaHotelViewModel, PousadaHotel>(pousada);
                    _pousadaHotelApp.Update(pousadaDomain);

                    return RedirectToAction("Index");
                }
                return View(pousada);
            }
            catch
            {
                return View();
            }
        }

        
        //
        // POST: /PousadaHotel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var pousadaDomain = _pousadaHotelApp.GetById(id);
                var pousadaViewModel = Mapper.Map<PousadaHotel, PousadaHotelViewModel>(pousadaDomain);

                return View(pousadaViewModel);
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
            var pousadaHotel = _pousadaHotelApp.GetById(id);
            _pousadaHotelApp.Remove(pousadaHotel);

            return RedirectToAction("Index");
        }
    }
}
