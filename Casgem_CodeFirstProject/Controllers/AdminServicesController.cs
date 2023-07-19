using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class AdminServicesController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.Services.ToList();
            return View(values);
        }

        public ActionResult DeleteAdminService(int id)
        {
            var value = travelContext.Services.Find(id);
            travelContext.Services.Remove(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAdminService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdminService(Service service)
        {
            travelContext.Services.Add(service);
            travelContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdminService(int id)
        {
            var value = travelContext.Services.Find(id);

            return View("Index");
        }

        [HttpPost]
        public ActionResult UpdateAdminService(Service service)
        {
            var value = travelContext.Services.Find(service.ServicesID);
            value.Title = service.Title;
            value.Description = service.Description;
            value.Icon = service.Icon;
            travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}