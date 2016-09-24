using DNAMais.BackOffice.Facades;
using DNAMais.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DNAMais.BackOffice.Areas.Cadastros.Controllers
{
    public class ContratoEmpresaController : Controller
    {
        private ContratoEmpresaFacade facade;

        public ContratoEmpresaController()
        {
            facade = new ContratoEmpresaFacade(ModelState);
        }

        protected override void Initialize(RequestContext context)
        {
            base.Initialize(context);

            ViewBag.Menu = "MENU-CONTRATO";
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing && this.facade != null)
            {
                this.facade.Dispose();
            }
        }

        //[AutorizacaoDnaMais]
        public ActionResult Index()
        {
            return View(facade.ListarContratos());
        }

        //[AutorizacaoDnaMais]
        public ActionResult Details(int id)
        {
            ViewData["LOCKED"] = true;
            return View("Cadastro", facade.ListarContratoPorId(id));
        }

        //[AutorizacaoDnaMais]
        public ActionResult Create()
        {
            return View("Cadastro", new ContratoEmpresa());
        }

        [HttpPost]
        //[AutorizacaoDnaMais]
        public ActionResult Create(ContratoEmpresa contratoEmpresa)
        {
            facade.SalvarContratoEmpresa(contratoEmpresa);
            return View("Cadastro", contratoEmpresa);
        }
    }
}