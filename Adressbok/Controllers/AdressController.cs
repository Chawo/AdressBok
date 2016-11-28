using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adressbok.Models;

namespace Adressbok.Controllers
{
    public class AdressController : Controller
    {
        public static IList<Adressboken> AdressList = new List<Adressboken>();

        // GET: Adress
        
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Adressboken newAdress)
        {
            AdressList.Add(newAdress);
            return PartialView("ListOfAdress", AdressList);
        }

        public ActionResult ListOfAdress()
        { 
            return PartialView("ListOfAdress", AdressList);
        }

        public ActionResult Edit(int id, string namn, string adress)
        {
            var showAdress = AdressList.FirstOrDefault(x => x.Id == id);
            return View(showAdress);
        }
        [HttpPost]
        public ActionResult Edit(int adressID)
        {
            var updatedAdress = AdressList.First().Id == adressID;
            return View(updatedAdress);
        }
    }
}