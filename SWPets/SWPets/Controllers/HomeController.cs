using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWPets.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pets()
        {
            return View();
        }

        public ActionResult Adotantes()
        {
            return View();
        }

        public ActionResult Estoque()
        {
            return View();
        }

        public ActionResult Ajuda()
        {
            return View();
        }


    }
}