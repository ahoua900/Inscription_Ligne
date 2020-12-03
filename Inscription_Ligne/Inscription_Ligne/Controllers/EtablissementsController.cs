using System;
using System.Collections.Generic;
using System.Linq;
using Inscription_Ligne.Models;
using Inscription_Ligne.DAL;
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
        [HttpPost]
        public ActionResult Register_Etablissement(Etablissement etablissement)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {

            }
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
        public ActionResult Dashboard_etablissement()
        {
            return View();
        }
        public ActionResult Liste_eleves()
        {
            return View();
        }
        public ActionResult Eleves()
        {
            return View();
        }
    }
}