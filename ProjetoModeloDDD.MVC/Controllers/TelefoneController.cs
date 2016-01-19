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
    public class TelefoneController : Controller
    {
        private readonly ITelefoneAppService _telefoneApp;

        public TelefoneController(ITelefoneAppService telefoneApp)
        {
            _telefoneApp = telefoneApp;
        }

        //
        // GET: /Telefone/
        public ActionResult Index()
        {
            var telefoneViewModel = Mapper.Map<IEnumerable<Telefone>, IEnumerable<TelefoneViewModel>>(_telefoneApp.GetAll());

            return View(telefoneViewModel);
        }

        //
        // GET: /Telefone/Details/5
        public ActionResult Details(int id)
        {
            var telefone = _telefoneApp.GetById(id);
            var telefoneViewModel = Mapper.Map<Telefone, TelefoneViewModel>(telefone);

            return View(telefoneViewModel);
        }

        //
        // GET: /Telefone/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Telefone/Create
        [HttpPost]
        public ActionResult Create(TelefoneViewModel telefoneViewModel)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var telefoneDomain = Mapper.Map<TelefoneViewModel, Telefone>(telefoneViewModel);
                    _telefoneApp.Add(telefoneDomain);
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
            var telefone = _telefoneApp.GetById(id);
            var telefoneViewModel = Mapper.Map<Telefone, TelefoneViewModel>(telefone);

            return View(telefoneViewModel);
        }

        //
        // POST: /Telefone/Edit/5
        [HttpPost]
        public ActionResult Edit(TelefoneViewModel telefoneViewModel)
        {
            try
            {
                // TODO: Add update logic here

                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var telefoneDomain = Mapper.Map<TelefoneViewModel, Telefone>(telefoneViewModel);
                    _telefoneApp.Update(telefoneDomain);

                    return RedirectToAction("Index");
                }
                return View(telefoneViewModel);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Telefone/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var telefoneDomain = _telefoneApp.GetById(id);
                var telefoneViewModel = Mapper.Map<Telefone, TelefoneViewModel>(telefoneDomain);

                return View(telefoneViewModel);
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
            var telefone = _telefoneApp.GetById(id);
            _telefoneApp.Remove(telefone);

            return RedirectToAction("Index");
        }
    }
}
