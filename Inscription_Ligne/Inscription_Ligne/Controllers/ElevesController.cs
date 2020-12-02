using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inscription_Ligne.Controllers
{
    public class ElevesController : Controller
    {
        // GET: Eleves
        public ActionResult Completer_dossiers()
        {
            return View();
        }
        public ActionResult Faire_versements()
        {
            return View();
        }
        public ActionResult Mes_versements()
        {
            return View();
        }
    }
}