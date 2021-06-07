using SWPets.Models;
using SWPets_BD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
            Banco novaConexao = new Banco();

            novaConexao.strQuerySelect();

            return View(pet);
        }

    }
}