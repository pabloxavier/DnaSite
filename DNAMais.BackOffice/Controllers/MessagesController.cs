using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNAMais.BackOffice.Controllers
{
    public class MessagesController : Controller
    {
        //
        // GET: /Messages/

        public ActionResult NotAnswered()
        {
            return View();
        }

        public ActionResult Answered()
        {
            return View();
        }

    }
}
