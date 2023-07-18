using Casgem_CodeFirstProject.DAL.Context;
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
        public ActionResult Index()
        {
            return View();
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