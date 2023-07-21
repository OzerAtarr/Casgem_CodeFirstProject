using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminContactUsController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.ContactUs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateContactUs(int id)
        {
            var value = travelContext.ContactUs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContactUs(ContactUs contactUs)
        {
            var value = travelContext.ContactUs.Find(contactUs.ID);
            ViewBag.Address = contactUs.Address;
            ViewBag.Phone = contactUs.Phone;
            ViewBag.Icon = contactUs.Icon;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}