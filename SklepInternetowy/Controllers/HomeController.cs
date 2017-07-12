using SklepInternetowy.DAL;
using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
        private KsiazkiContext db = new KsiazkiContext();

        public ActionResult Index()
        {
            var listaKategorii = db.Kategorie.ToList();
            return View();
        }
    }
}