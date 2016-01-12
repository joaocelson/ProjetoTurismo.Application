using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TurismoDDD.MVC.ViewModels;
using TurismoDDD.Infra.Data.Contexto;
using TurismoDDD.Application.Interface;
using AutoMapper;
using TurismoDDD.Domain.Entities;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class TipoEstabelecimentoController : Controller
    {

        private readonly ITipoEstabelecimentoAppService _estabelecimentoApp;


        public TipoEstabelecimentoController(ITipoEstabelecimentoAppService estabelecimentoApp)
        {
            _estabelecimentoApp = estabelecimentoApp;
        }
        // GET: /TipoEstabelecimento/
        public ActionResult Index()
        {
            var tipoEstabelecimentoViewModel = Mapper.Map<IEnumerable<TipoEstabelecimento>, IEnumerable<TipoEstabelecimentoViewModel>>(_estabelecimentoApp.GetAll());
            return View(tipoEstabelecimentoViewModel);
        }

        // GET: /TipoEstabelecimento/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {

                var tipoEstabelecimento = _estabelecimentoApp.GetById(id);
                var tipoPessoaViewModel = Mapper.Map<TipoEstabelecimento, TipoEstabelecimentoViewModel>(tipoEstabelecimento);

                return View(tipoPessoaViewModel);
            }
        }

        // GET: /TipoEstabelecimento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TipoEstabelecimento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoPessoaId,Descricao,DataCadastro")] TipoEstabelecimentoViewModel tipoEstabeleciomentoModel)
        {
            if (ModelState.IsValid)
            {
                var tipoEstabelecimentoDomain = Mapper.Map<TipoEstabelecimentoViewModel, TipoEstabelecimento>(tipoEstabeleciomentoModel);
                _estabelecimentoApp.Add(tipoEstabelecimentoDomain);

                return RedirectToAction("Index");
            }

            return View(tipoEstabeleciomentoModel);
        }

        // GET: /TipoEstabelecimento/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                var tipoEstabelecimento = _estabelecimentoApp.GetById(id);
                var tipoEstabelecimentoViewModel = Mapper.Map<TipoEstabelecimento, TipoEstabelecimentoViewModel>(tipoEstabelecimento);

                return View(tipoEstabelecimentoViewModel);
            }
        }

        // POST: /TipoEstabelecimento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoEstabelecimentoId,Descricao,DataCadastro")] TipoEstabelecimentoViewModel tipoEstabelecimentoViewModel)
        {
            if (ModelState.IsValid)
            {
                var tipoEstabelecimentoDomain = Mapper.Map<TipoEstabelecimentoViewModel, TipoEstabelecimento>(tipoEstabelecimentoViewModel);
                _estabelecimentoApp.Update(tipoEstabelecimentoDomain);

                return RedirectToAction("Index");
            }

            return View(tipoEstabelecimentoViewModel);
        }

        // GET: /TipoEstabelecimento/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                var tipoEstabelecimento = _estabelecimentoApp.GetById(id);
                var tipoEstabelecimentoViewModel = Mapper.Map<TipoEstabelecimento, TipoEstabelecimentoViewModel>(tipoEstabelecimento);

                return View(tipoEstabelecimentoViewModel);
            }
        }

        // POST: /TipoEstabelecimento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var tipoEstabelecimento = _estabelecimentoApp.GetById(id);
            _estabelecimentoApp.Remove(tipoEstabelecimento);

            return RedirectToAction("Index");
        }
    }
}
