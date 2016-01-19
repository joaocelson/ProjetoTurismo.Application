using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TurismoDDD.Application.Interface;
using TurismoDDD.Domain.Entities;
using TurismoDDD.MVC.ViewModels;
using System.IO;
using System.Drawing;
using System;
using Util;
using System.Web.Hosting;

namespace TurismoDDD.MVC.Controllers
{
    public class EstabelecimentosController : Controller
    {

        // GET: Produtos
        private readonly IEstabelecimentoAppService _estabelecimentoApp;
        private readonly IUsuarioAppService _pessoaApp;

        public EstabelecimentosController(IEstabelecimentoAppService estabelecimentoApp, IUsuarioAppService pessoaApp)
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

        public Image Base64ToImage(string base64String)
        {
            try
            {
                // Convert Base64 String to byte[]
                byte[] imageBytes = Convert.FromBase64String(base64String);
                // Convert byte[] to Image
                // System.IO.File.WriteAllBytes("c:\\publish\\imagens\\teste.png", imageBytes);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    Image image = Image.FromStream(ms, true);
                    return image;
                }
            }
            catch (Exception e)
            {
                TratamentoLog.GravarLog("EstabelecimentoController:Base64ToImage: " + e.Message, TratamentoLog.NivelLog.Erro);
                TratamentoLog.GravarLog("EstabelecimentoController:Base64ToImage: " + e.StackTrace, TratamentoLog.NivelLog.Erro);
                throw;
            }
        }

        // POST: Cliente/Create
        [HttpPost]// public ActionResult Create([Bind(Include = "nomeCasa,numeroPessoas,telefoneCasa,fotoPerfil,idPessoa")] EstabelecimentoViewModel estabelecimentoView)
        public JsonResult Create(EstabelecimentoViewModel estabelecimentoView)//public JsonResult Create(String nomeCasa, String numeroPessoas, String telefoneCasa, String fotoPerfil, String idPessoa)
        {
            try
            {
                TratamentoLog.GravarLog("Valor do FotoPerfil: " + estabelecimentoView.NomeFotoPerfil);

                var estabelecimentoDomain = Mapper.Map<EstabelecimentoViewModel, Estabelecimento>(estabelecimentoView);

                Image returnImage = Base64ToImage(estabelecimentoDomain.NomeFotoPerfil);

                if (!Directory.Exists(HostingEnvironment.ApplicationPhysicalPath + "\\imagens"))
                {
                    Directory.CreateDirectory(HostingEnvironment.ApplicationPhysicalPath + "\\imagens");
                }
                estabelecimentoDomain.NomeFotoPerfil = HostingEnvironment.ApplicationPhysicalPath + "\\imagens\\" + estabelecimentoDomain.UsuarioId + "_" + estabelecimentoDomain.Nome + "_" + DateTime.Now.Millisecond;

                returnImage.Save(estabelecimentoDomain.NomeFotoPerfil + ".jpg");

                _estabelecimentoApp.Add(estabelecimentoDomain);

                return Json(new { EstabelecimentoId = estabelecimentoDomain.EstabelecimentoId });
            }
            catch (Exception e)
            {
                TratamentoLog.GravarLog("EstabelecimentoController:Create: " + e.Message, TratamentoLog.NivelLog.Erro);
                TratamentoLog.GravarLog("EstabelecimentoController:Create: " + e.StackTrace, TratamentoLog.NivelLog.Erro);
                throw;
            }
        }


        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Cadastro(String nomeCasa, String numeroPessoas, String telefoneCasa, String fotoPerfil, String idPessoa)
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
                    returnImage.Save(AppDomain.CurrentDomain.BaseDirectory + "/imagens/" + estabelecimentoDomain.UsuarioId + "_" + estabelecimentoDomain.Nome + "_" + DateTime.Today.ToString());
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