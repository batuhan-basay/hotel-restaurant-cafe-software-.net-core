using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaceSite.Models;

namespace PlaceSite.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();

        // GET: About
        public ActionResult Index(int id)
        {
            var values = c.Abouts.Where(x => x.Id == id).ToList();
            var aboutus = c.Abouts.Where(x => x.Id == id).Select(y => y.AboutUs).FirstOrDefault();
            ViewBag.aboutus = aboutus;
            var img = c.Abouts.Where(x => x.Id == id).Select(y => y.Img).FirstOrDefault();
            ViewBag.img = img;

            return View(values);
        }
    }
}