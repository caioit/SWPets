using SWPets.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            var pet = new Pet
            {

            };

            ViewData["senha"] = ConfigurationManager.AppSettings["UninoveSWPets"];

            return View(pet);
        }

        public ActionResult Adotantes()
        {
            return View();
        }

        public ActionResult Estoque()
        {
            ViewBag.Message = "Estoque";        
            return View();
        }

        public ActionResult Ajuda()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pet pet)
        {
            

            return View(pet);
        }


    }
}