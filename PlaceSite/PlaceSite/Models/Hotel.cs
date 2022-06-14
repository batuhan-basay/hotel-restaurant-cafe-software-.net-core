using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaceSite.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string HotelName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(80)]
        public string Adress { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(3)]
        public string Status { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string Explanation { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(800)]
        public string Location { get; set; }
        public int Star { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string CoverImg { get; set; }


        public ICollection<HotelComment> HotelComments { get; set; }
        public ICollection<Price> Prices { get; set; }
        public virtual Price Pricess { get; set; }

        public virtual HotelClass Class { get; set; }
        public virtual HotelGallery HotelGalleryId { get; set; }
        public ICollection<HotelGallery> HotelGallerys { get; set; }
    }
}