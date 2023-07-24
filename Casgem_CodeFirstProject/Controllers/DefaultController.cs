using Casgem_CodeFirstProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            ViewBag.adress = travelContext.ContactUs.Select(x => x.Address).FirstOrDefault();
            ViewBag.phone = travelContext.ContactUs.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = travelContext.ContactUs.Select(x => x.Email).FirstOrDefault();
            ViewBag.icon = travelContext.ContactUs.Select(x => x.Icon).FirstOrDefault();
            return PartialView();
        }     
        public PartialViewResult PartialSliderScript()
        {

            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            var values = travelContext.Sliders.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialBooking()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialDestinations()
        {
            var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult PartialBookingCover()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            ViewBag.adress = travelContext.ContactUs.Select(x => x.Address).FirstOrDefault();
            ViewBag.phone = travelContext.ContactUs.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = travelContext.ContactUs.Select(x => x.Email).FirstOrDefault();
            ViewBag.icon = travelContext.ContactUs.Select(x => x.Icon).FirstOrDefault();
            ViewBag.categoryName = travelContext.Categories.Select(x => x.CategoryName).ToList();
            return PartialView();
        }

        public PartialViewResult PartialSocialMedia()
        {
            var values = travelContext.FooterSocialMedias.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCategory()
        {
            var values = travelContext.Categories.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialGalery()
        {
            var values = travelContext.Galleries.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTravelTrip()
        {
            var values = travelContext.TravelTrips.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMainScript()
        {
            return PartialView();
        }
    }
}