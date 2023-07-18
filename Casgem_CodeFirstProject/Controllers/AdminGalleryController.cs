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
    public class AdminGalleryController : Controller
    {
            TravelContext travelContext = new TravelContext();
            public ActionResult Index()
            {
                var values = travelContext.Galleries.ToList();
                return View(values);
            }

            [HttpGet]
            public ActionResult AddGallery()
            {
                return View();
            }
            [HttpPost]
            public ActionResult AddGallery(Gallery gallery)
            {
                travelContext.Galleries.Add(gallery);
                travelContext.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult DeleteGallery(int id)
            {
                var value = travelContext.Galleries.Find(id);
                travelContext.Galleries.Remove(value);
                travelContext.SaveChanges();
                return RedirectToAction("Index");
            }
            [HttpGet]
            public ActionResult UpdateGallery(int id)
            {
                var value = travelContext.Galleries.Find(id);
                return View(value);
            }

            [HttpPost]
            public ActionResult UpdateGallery(Gallery gallery)
            {
                var value = travelContext.Galleries.Find(gallery.GalleryID);
                value.Title = gallery.Title;
                value.Description = gallery.Description;
                value.ImageUrl = gallery.ImageUrl;
                travelContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }
}
