using Revisao.Domain.Entities;
using Revisao.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Revisao.Web.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        PessoaJuridicaRepository repositorio = new PessoaJuridicaRepository();
       
        // GET: PessoaJuridica

        public ActionResult Index()
        {
            return View();
        }
        
    }
}