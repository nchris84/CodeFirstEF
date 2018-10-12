using CodeFirstEF.DAL;
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
            using (var context = new KontaktyContext())
            {
                List<Kontakt> list = context.Kontakty.ToList();
                return View(list);
            }

        }

        public ActionResult DodajKontakt()
        {
            return View("DodajKontakt");
        }

        [HttpPost]
        public ActionResult DodajKontakt(Kontakt kontakt)
        {
            using (KontaktyContext context = new KontaktyContext())
            {
                if(!ModelState.IsValid)
                {
                    return View("DodajKontakt", kontakt);
                }
                else
                {
                    context.Kontakty.Add(kontakt);
                    context.SaveChanges();
                }

            }

                return View("DodajKontakt");
        }
    }
}