using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaceSite.Models;


namespace PlaceSite.Controllers
{
    public class HotelController : Controller
    {
        Context c = new Context();
        // GET: Hotel
        public ActionResult Index()
        {
            var values = c.Hotels.Where(x => x.Status == "1").ToList();
            return View(values);
        }
        public ActionResult HotelDetail(int id)
        {
            var values = c.Hotels.Where(x => x.Id == id).ToList();
            var Name = c.Hotels.Where(x => x.Id == id).Select(y => y.HotelName).FirstOrDefault();
            ViewBag.names = Name;
            var Adress = c.Hotels.Where(x => x.Id == id).Select(y => y.Adress).FirstOrDefault();
            ViewBag.adress = Adress;
            var Explanation = c.Hotels.Where(x => x.Id == id).Select(y => y.Explanation).FirstOrDefault();
            ViewBag.explanations = Explanation;
            var Location = c.Hotels.Where(x => x.Id == id).Select(y => y.Location).FirstOrDefault();
            ViewBag.location = Location;
            var Coverimg = c.Hotels.Where(x => x.Id == id).Select(y => y.CoverImg).FirstOrDefault();
            ViewBag.coverimg = Coverimg;
            var Class = c.Hotels.Where(x => x.Id == id).Select(y => y.Class.Type).FirstOrDefault();
            ViewBag.classes = Class;
            var Status = c.Hotels.Where(x => x.Id == id).Select(y => y.Status).FirstOrDefault();
            ViewBag.status = Status;
            return View(values);
        }
    }
}