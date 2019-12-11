using Revisao.Domain.Entities;
using Revisao.Repository.Repositories;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revisao.Web.Controllers
{
    public class PessoaFisicaController : Controller
    {
        PessoaFisicaRepository repositorio = new PessoaFisicaRepository();

        // GET: PessoaFisisca
        public ActionResult Index()
        {
            return View();
        }
        //List
        public ActionResult List()
        {
            return View(repositorio.ListAll());
        }
        //Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(PessoaFisica model)
        {
            repositorio.Insert(model);
            ModelState.Clear();
            return RedirectToAction("index");
        }
        //Edit
        [HttpGet]
        public ActionResult Edit(int id)
        {
            PessoaFisica model = repositorio.GetById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(PessoaFisica model)
        {
            repositorio.Update(model);
            ModelState.Clear();
            return RedirectToAction("index");
        }
        //Delete
        public ActionResult Delete(int id)
        {
            repositorio.Delete(id);
            return RedirectToAction("index");
        }
        //Details
        public ActionResult Details(int id)
        {
            PessoaFisica model = repositorio.GetById(id);
            return View(model);
        }
    }
}