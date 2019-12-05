using Cs483.Dados;
using Cs483.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cs483.WebApp.Controllers
{
    public class TipoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ClasseTipo model)
        {
            TipoRepositorio repositorio = new TipoRepositorio();
            repositorio.Inserir(model);
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            TipoRepositorio repositorio = new TipoRepositorio();
            ClasseTipo model = repositorio.BuscarPorId(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ClasseTipo model)
        {
            TipoRepositorio repositorio = new TipoRepositorio();
            repositorio.Editar(model);
            ViewBag.Mensage = "Salvo com Sucesso!";
            return View();
        }

        
    }
}