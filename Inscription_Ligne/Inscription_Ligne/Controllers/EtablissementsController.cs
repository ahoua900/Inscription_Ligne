using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inscription_Ligne.Controllers
{
    public class EtablissementsController : Controller
    {
        // GET: Etablissements
        public ActionResult Register_Etablissement()
        {
            return View();
        }
        public ActionResult Verification_eleves()
        {
            return View();
        }
        public ActionResult Inscription_eleves()
        {
            return View();
        }
    }
}