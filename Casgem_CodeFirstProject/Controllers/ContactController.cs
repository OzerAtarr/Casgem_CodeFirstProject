using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class ContactController : Controller
    {
        TravelContext travelContext = new TravelContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            travelContext.Contacts.Add(contact);
            travelContext.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
        public PartialViewResult PartialContactUs()
        {
            ViewBag.adress = travelContext.ContactUs.Select(x => x.Address).FirstOrDefault();
            ViewBag.phone = travelContext.ContactUs.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = travelContext.ContactUs.Select(x => x.Email).FirstOrDefault();
            return PartialView();
        }
    }
}