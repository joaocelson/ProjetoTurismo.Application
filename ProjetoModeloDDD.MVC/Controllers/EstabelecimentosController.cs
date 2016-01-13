﻿using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;
using System.IO;
using System.Drawing;
using System;
using Util;

namespace TurismoDDD.MVC.Controllers
{
    public class EstabelecimentosController : Controller
    {
        // GET: Produtos
        private readonly IEstabelecimentoAppService _estabelecimentoApp;
        private readonly IPessoaAppService _pessoaApp;

        public EstabelecimentosController(IEstabelecimentoAppService estabelecimentoApp, IPessoaAppService pessoaApp)
        {
            _estabelecimentoApp = estabelecimentoApp;
            _pessoaApp = pessoaApp;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var estabelecimentoViewModel = Mapper.Map<IEnumerable<Estabelecimento>, IEnumerable<EstabelecimentoViewModel>>(_estabelecimentoApp.GetAll());

            return View(estabelecimentoViewModel);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

            return View(estabelecimentoViewModel);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.PessoaId = new SelectList(_pessoaApp.GetAll(), "PessoaId", "Nome");
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nomeCasa,numeroPessoas,telefoneCasa,fotoPerfil,idPessoa")] EstabelecimentoViewModel estabelecimentoView)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var estabelecimentoDomain = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimentoView);

                    byte[] byteArrayIn = System.Text.Encoding.ASCII.GetBytes(estabelecimentoDomain.NomeFotoPerfil);
                    MemoryStream ms = new MemoryStream(byteArrayIn);
                    Image returnImage = Image.FromStream(ms);
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/imagens"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/imagens");
                    }
                    returnImage.Save(AppDomain.CurrentDomain.BaseDirectory + "/imagens/" + estabelecimentoDomain.PessoaId + "_" + estabelecimentoDomain.Nome + "_" + DateTime.Today.ToString());
                    _estabelecimentoApp.Add(estabelecimentoDomain);

                    return RedirectToAction("Index");
                }

                ViewBag.PessoaId = new SelectList(_pessoaApp.GetAll(), "PessoaId", "Nome", estabelecimentoView.PessoaId);

                return View(estabelecimentoView);
            }
            catch (Exception e)
            {
                TratamentoLog.GravarLog("EstabelecimentoController:Create: " + e.Message, TratamentoLog.NivelLog.Erro);
                TratamentoLog.GravarLog("EstabelecimentoController:Create: " + e.TargetSite, TratamentoLog.NivelLog.Erro);

                throw;
            }
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Cadastro(String nomeCasa,String numeroPessoas,String telefoneCasa,String fotoPerfil,String idPessoa)
        {
            try
            {
                EstabelecimentoViewModel estabelecimentoView = new EstabelecimentoViewModel();
                if (ModelState.IsValid)
                {
                  
                    estabelecimentoView.Nome = nomeCasa;
                    estabelecimentoView.NomeFotoPerfil = fotoPerfil;
                    estabelecimentoView.PessoaId = Convert.ToInt32(idPessoa);

                    var estabelecimentoDomain = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimentoView);

                    byte[] byteArrayIn = System.Text.Encoding.ASCII.GetBytes(estabelecimentoDomain.NomeFotoPerfil);
                    MemoryStream ms = new MemoryStream(byteArrayIn);
                    Image returnImage = Image.FromStream(ms);
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/imagens"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/imagens");
                    }
                    returnImage.Save(AppDomain.CurrentDomain.BaseDirectory + "/imagens/" + estabelecimentoDomain.PessoaId + "_" + estabelecimentoDomain.Nome + "_" + DateTime.Today.ToString());
                    _estabelecimentoApp.Add(estabelecimentoDomain);

                    return RedirectToAction("Index");
                }

                ViewBag.PessoaId = new SelectList(_pessoaApp.GetAll(), "PessoaId", "Nome", estabelecimentoView.PessoaId);

                return View(estabelecimentoView);
            }
            catch (Exception e)
            {
                TratamentoLog.GravarLog("EstabelecimentoController:Create: " + e.Message, TratamentoLog.NivelLog.Erro);
                TratamentoLog.GravarLog("EstabelecimentoController:Create: " + e.TargetSite, TratamentoLog.NivelLog.Erro);

                throw;
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

            ViewBag.PessoaId = new SelectList(_pessoaApp.GetAll(), "PessoaId", "Nome", estabelecimentoViewModel.PessoaId);

            return View(estabelecimentoViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstabelecimentoViewModel estabelecimento)
        {
            if (ModelState.IsValid)
            {
                var estabelecimentoDomain = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimento);
                _estabelecimentoApp.Update(estabelecimentoDomain);

                return RedirectToAction("Index");
            }

            ViewBag.PessoaId = new SelectList(_pessoaApp.GetAll(), "PessoaId", "Nome", estabelecimento.PessoaId);
            return View(estabelecimento);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            var estabelecimentoViewModel = Mapper.Map<Estabelecimento, EstabelecimentoViewModel>(estabelecimento);

            return View(estabelecimentoViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var estabelecimento = _estabelecimentoApp.GetById(id);
            _estabelecimentoApp.Remove(estabelecimento);

            return RedirectToAction("Index");
        }
    }
}