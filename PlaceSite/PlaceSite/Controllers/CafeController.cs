using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaceSite.Models;

namespace PlaceSite.Controllers
{
    public class CafeController : Controller
    {
        Context c = new Context();
        // GET: Cafe
        public ActionResult Index()
        {
            var values = c.Cafes.Where(x => x.Status == "1").ToList();
            return View(values);
        }

       
        public ActionResult CafeDetail(int id)
        {
            var values = c.Cafes.Where(x => x.Id == id).ToList();
            var Name = c.Cafes.Where(x => x.Id == id).Select(y => y.CafeName).FirstOrDefault();
            ViewBag.names = Name;
            var Adress = c.Cafes.Where(x => x.Id == id).Select(y => y.Adress).FirstOrDefault();
            ViewBag.adress = Adress;
            var Explanation = c.Cafes.Where(x => x.Id == id).Select(y => y.Explanation).FirstOrDefault();
            ViewBag.explanations = Explanation;
            var Location = c.Cafes.Where(x => x.Id == id).Select(y => y.Location).FirstOrDefault();
            ViewBag.location = Location;
            var Coverimg = c.Cafes.Where(x => x.Id == id).Select(y => y.CoverImg).FirstOrDefault();
            ViewBag.coverimg = Coverimg;
            var Class = c.Cafes.Where(x => x.Id == id).Select(y => y.Class.Type).FirstOrDefault();
            ViewBag.classes = Class;
            var Status = c.Cafes.Where(x => x.Id == id).Select(y => y.Status).FirstOrDefault();
            ViewBag.status = Status;
            return View(values);
        }

    }
}