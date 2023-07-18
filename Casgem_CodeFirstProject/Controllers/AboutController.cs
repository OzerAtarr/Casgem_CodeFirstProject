using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AboutController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialGuide()
        {
            var values = travelContext.Guides.Include("SocialMedia").ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            ViewBag.title1 = travelContext.Abouts.Select(x=>x.Title1).FirstOrDefault();
            ViewBag.title2 = travelContext.Abouts.Select(x => x.Title2).FirstOrDefault();
            ViewBag.title3 = travelContext.Abouts.Select(x => x.Title3).FirstOrDefault();
            ViewBag.description1 = travelContext.Abouts.Select(x => x.Description1).FirstOrDefault();
            ViewBag.description2 = travelContext.Abouts.Select(x => x.Description2).FirstOrDefault();
            ViewBag.description3 = travelContext.Abouts.Select(x => x.Description3).FirstOrDefault();
            ViewBag.imageUrl1 = travelContext.Abouts.Select(x => x.ImageUrl1).FirstOrDefault();
            ViewBag.imageUrl2 = travelContext.Abouts.Select(x => x.ImageUrl2).FirstOrDefault();
            ViewBag.imageUrl3 = travelContext.Abouts.Select(x => x.ImageUrl3).FirstOrDefault();
            return PartialView();
        }
    }
}