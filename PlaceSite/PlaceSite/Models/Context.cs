using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PlaceSite.Models
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Cafe> Cafes { get; set; }
        public DbSet<CafeClass> CafeClasses{ get; set; }
        public DbSet<CafeGallery> CafeGalleries{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Menu> Menus{ get; set; }
        public DbSet<Hotel> Hotels{ get; set; }
        public DbSet<HotelComment> HotelComments{ get; set; }
        public DbSet<Price> Prices{ get; set; }
        public DbSet<HotelClass> hotelClasses{ get; set; }
        public DbSet<HotelGallery> hotelGalleries{ get; set; }

    }
}