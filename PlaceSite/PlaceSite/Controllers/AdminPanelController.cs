using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaceSite.Models;

namespace PlaceSite.Controllers
{
    public class AdminPanelController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index(string p)
        {
            var list = from x in c.Admins select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.UserName.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult AdminAdd()
        {
            List<SelectListItem> value1 = (from x in c.Admins.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UserName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdd(Admin p)
        {
            c.Admins.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AdminDelete(int id)
        {
            var value = c.Admins.Find(id);
            
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AdminUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.Admins.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UserName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.Admins.Find(id);
            return View("AdminUpgrade", values);
        }

        public ActionResult AdminUpdate(Admin p)
        {
            var admin = c.Admins.Find(p.Id);
            admin.UserName = p.UserName;
            admin.Password = p.Password;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        // About
     

      
        public ActionResult AboutUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.Abouts.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.AboutUs,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.Abouts.Find(id);
            return View("AboutUpgrade", values);
        }

        public ActionResult AboutUpdate(About p)
        {
            var about = c.Abouts.Find(p.Id);
            about.AboutUs = p.AboutUs;
            about.Img = p.Img;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        // cafe
        public ActionResult CafeInfo(string p)
        {
            var list = from x in c.Cafes select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.CafeName.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult CafeAdd()
        {
            List<SelectListItem> value1 = (from x in c.Cafes.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CafeName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult CafeAdd(Cafe p)
        {
            c.Cafes.Add(p);
            c.SaveChanges();
            return RedirectToAction("CafeInfo");
        }

        public ActionResult CafeDelete(int id)
        {
            var value = c.Cafes.Find(id);
            value.Status = "0";
            c.SaveChanges();
            return RedirectToAction("CafeInfo");
        }
        public ActionResult CafeUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.Cafes.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CafeName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.Cafes.Find(id);
            return View("CafeUpgrade", values);
        }

        public ActionResult CafeUpdate(Cafe p)
        {
            var cafe = c.Cafes.Find(p.Id);
            cafe.CafeName = p.CafeName;
            cafe.Adress = p.Adress;
            cafe.Status = p.Status;
            cafe.Explanation = p.Explanation;
            cafe.Location = p.Location;
            cafe.CoverImg = p.CoverImg;
            c.SaveChanges();

            return RedirectToAction("CafeInfo");
        }

        // Menu
        public ActionResult Menu(string p)
        {
            var list = from x in c.Menus select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.FoodName.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult MenuAdd()
        {
            List<SelectListItem> value1 = (from x in c.Menus.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.FoodName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult MenuAdd(Menu p)
        {
            c.Menus.Add(p);
            c.SaveChanges();
            return RedirectToAction("Menu");
        }

       
        public ActionResult MenuUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.Menus.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.FoodName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.Menus.Find(id);
            return View("MenuUpgrade", values);
        }

        public ActionResult MenuUpdate(Menu p)
        {
            var cafe = c.Menus.Find(p.Id);
            cafe.FoodName = p.FoodName;
            cafe.Explanation = p.Explanation;
            cafe.Price = p.Price;
            c.SaveChanges();

            return RedirectToAction("Menu");
        }

        // Cafe Class
        public ActionResult CafeClass(string p)
        {
            var list = from x in c.CafeClasses select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.Type.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult CafeClassAdd()
        {
            List<SelectListItem> value1 = (from x in c.CafeClasses.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Type,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult CafeClassAdd(CafeClass p)
        {
            c.CafeClasses.Add(p);
            c.SaveChanges();
            return RedirectToAction("CafeClass");
        }


        public ActionResult CafeClassUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.CafeClasses.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Type,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.CafeClasses.Find(id);
            return View("CafeClassUpgrade", values);
        }

        public ActionResult CafeClassUpdate(CafeClass p)
        {
            var cafe = c.CafeClasses.Find(p.Id);
            cafe.Type = p.Type;
            c.SaveChanges();

            return RedirectToAction("CafeClass");
        }

        // Hotel Info
        public ActionResult HotelInfo(string p)
        {
            var list = from x in c.Hotels select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.HotelName.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult HotelAdd()
        {
            List<SelectListItem> value1 = (from x in c.Hotels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.HotelName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult HotelAdd(Hotel p)
        {
            c.Hotels.Add(p);
            c.SaveChanges();
            return RedirectToAction("HotelInfo");
        }
        public ActionResult HotelDelete(int id)
        {
            var value = c.Hotels.Find(id);
            value.Status = "0";
            c.SaveChanges();
            return RedirectToAction("HotelInfo");
        }

        public ActionResult HotelUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.Hotels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.HotelName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.Hotels.Find(id);
            return View("HotelUpgrade", values);
        }

        public ActionResult HotelUpdate(Hotel p)
        {
            var hotel = c.Hotels.Find(p.Id);
            hotel.HotelName = p.HotelName;
            hotel.Adress = p.Adress;
            hotel.Status = p.Status;
            hotel.Explanation = p.Explanation;
            hotel.Location = p.Location;
            hotel.Star= p.Star;
            hotel.CoverImg= p.CoverImg;
            c.SaveChanges();

            return RedirectToAction("HotelInfo");
        }

        // Price 
        public ActionResult Price(string p)
        {
            var list = from x in c.Prices select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.RoomName.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult PriceAdd()
        {
            List<SelectListItem> value1 = (from x in c.Prices.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.RoomName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult PriceAdd(Price p)
        {
            c.Prices.Add(p);
            c.SaveChanges();
            return RedirectToAction("Price");
        }
      

        public ActionResult PriceUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.Prices.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.RoomName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.Prices.Find(id);
            return View("PriceUpgrade", values);
        }

        public ActionResult PriceUpdate(Price p)
        {
            var hotel = c.Prices.Find(p.Id);
            hotel.RoomName = p.RoomName;
            hotel.RoomPrice = p.RoomPrice;

            c.SaveChanges();

            return RedirectToAction("Price");
        }

        // Hotel Class
        public ActionResult HotelClass(string p)
        {
            var list = from x in c.hotelClasses select x;
            if (!string.IsNullOrEmpty(p))
            { list = list.Where(y => y.Type.Contains(p)); }
            return View(list.ToList());
        }

        [HttpGet]
        public ActionResult HotelClassAdd()
        {
            List<SelectListItem> value1 = (from x in c.hotelClasses.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Type,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult HotelClassAdd(HotelClass p)
        {
            c.hotelClasses.Add(p);
            c.SaveChanges();
            return RedirectToAction("HotelClass");
        }


        public ActionResult HotelClassUpgrade(int id)
        {
            List<SelectListItem> value1 = (from x in c.hotelClasses.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Type,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.value1 = value1;
            var values = c.hotelClasses.Find(id);
            return View("HotelClassUpgrade", values);
        }

        public ActionResult HotelClassUpdate(HotelClass p)
        {
            var hotel = c.hotelClasses.Find(p.Id);
            hotel.Type = p.Type;
            c.SaveChanges();

            return RedirectToAction("HotelClass");
        }

    }
}