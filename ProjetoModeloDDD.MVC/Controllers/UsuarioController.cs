﻿using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;
using System;
using System.Linq;
using Newtonsoft.Json;

namespace TurismoDDD.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAppService _pessoaApp;

        public UsuarioController(IUsuarioAppService pessoaApp)
        {
            _pessoaApp = pessoaApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_pessoaApp.GetAll());
            return View(pessoaViewModel);
        }

        // GET: Clientes
        public JsonResult Get()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_pessoaApp.GetAll())
                .Select(p => new
                {
                    pessoaId = p.PessoaId,
                    nome = p.Nome,
                    ativo = p.Ativo,
                    dataCadastro = p.DataCadastro,
                    sobrenome = p.Sobrenome
                });
            return Json(new { Pessoas = pessoaViewModel }, JsonRequestBehavior.AllowGet);

        }

        public ActionResult Especiais()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_pessoaApp.GetAll()); //(_pessoaApp.ObterPessoasEspeciais());

            return View(pessoaViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Usuario, UsuarioViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<UsuarioViewModel, Usuario>(pessoa);
                _pessoaApp.Add(pessoaDomain);

                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Usuario, UsuarioViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<UsuarioViewModel, Usuario>(pessoa);
                _pessoaApp.Update(pessoaDomain);

                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Usuario, UsuarioViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            _pessoaApp.Remove(pessoa);

            return RedirectToAction("Index");
        }


    }
}
