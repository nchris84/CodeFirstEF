﻿using CodeFirstEF.DAL;
using CodeFirstEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajKontakt(Kontakt kontakt)
        {
            using (KontaktyContext context = new KontaktyContext())
            {
                if(!ModelState.IsValid)
                {
                    return View("Index", kontakt);
                }
                else
                {
                    context.Kontakty.Add(kontakt);
                    context.SaveChanges();
                }

            }

                return View("Index");
        }
    }
}