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
    public class ClienteEmpresaController : Controller
    {
        private ClienteEmpresaFacade facade;

        public ClienteEmpresaController()
        {
            facade = new ClienteEmpresaFacade(ModelState);
        }

        protected override void Initialize(RequestContext context)
        {
            base.Initialize(context);

            ViewBag.Menu = "MENU-CLIENTE";
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
            return View(facade.ListarClientesEmpresa());
        }

        //[AutorizacaoDnaMais]
        public ActionResult Details(int id)
        {
            ViewData["LOCKED"] = true;
            return View("Cadastro", facade.ConsultarClienteEmpresaPorId(id));
        }

        //[AutorizacaoDnaMais]
        public ActionResult Create()
        {
            return View("Cadastro", new ClienteEmpresa());
        }

        [HttpPost]
        //[AutorizacaoDnaMais]
        public ActionResult Create(ClienteEmpresa clienteEmpresa)
        {
            facade.SalvarClienteEmpresa(clienteEmpresa);
            return View("Cadastro", clienteEmpresa);
        }

    }
}
