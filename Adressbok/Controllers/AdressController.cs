﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Adressbok.Models;

namespace Adressbok.Controllers
{
    public class AdressController : Controller
    {
        private static IList<Adressboken> AdressList = new List<Adressboken>();

        // GET: Adress

       
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Adressboken newAdress)
        {
            newAdress.Id = Guid.NewGuid();
            AdressList.Add(newAdress);
            return PartialView("ListOfAdresses", AdressList);
            //return View();
        }

        public ActionResult ListOfAdresses()
        {
            return PartialView("ListOfAdresses", AdressList);
        }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var adressID = AdressList.First(x => x.Id == id);
            return View(adressID);
        }
        [HttpPost]
        public ActionResult Edit(Guid Id, string namn, string adress, DateTime tidpunkt)
        {
            var newAdress = AdressList.First(x => x.Id == Id);
            if (newAdress != null)
            {
                newAdress.Namn = namn;
                newAdress.Adress = adress;
                newAdress.Tidpunkt = tidpunkt;

            }
            return View(newAdress);
        }
        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            var Deleteid = AdressList.First(x => x.Id == id);

            return View(Deleteid);
        }
        [HttpPost]
        public ActionResult Delete(Adressboken adress)
        {
            var aa = AdressList.First(x => x.Id == adress.Id);
            AdressList.Remove(aa);
            return View();
        }
    }
}