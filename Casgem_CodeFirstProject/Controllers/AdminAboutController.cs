using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    [Authorize]
    public class AdminAboutController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = travelContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = travelContext.Abouts.Find(about.AboutID);
            value.Title1 = about.Title1;
            value.Title2 = about.Title2;
            value.Title3 = about.Title3;
            value.Description1 = about.Description1;
            value.Description2 = about.Description2;
            value.Description3 = about.Description3;
            value.ImageUrl1 = about.ImageUrl1;
            value.ImageUrl2 = about.ImageUrl2;
            value.ImageUrl3 = about.ImageUrl3;
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}