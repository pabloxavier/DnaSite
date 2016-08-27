using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNAMais.Site.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Logged()
        {
            return View();
        }

        public ActionResult PesquisaPessoaFisica()
        {
            return View();
        }

        public ActionResult PesquisaPessoaJuridica()
        {
            return View();
        }

        public ActionResult PesquisaFtp()
        {
            return View();
        }

        public ActionResult PesquisaVeiculo()
        {
            return View();
        }

    }
}
