using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaceSite.Models
{
    public class Cafe
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CafeName { get; set; }
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

        public ICollection<Comment> Comments { get; set; }
        public virtual Menu Menu { get; set; }

        public virtual CafeClass Class { get; set; }
        public virtual CafeGallery CafeGallery_Id { get; set; }
        public ICollection<CafeGallery> CafeGallerys { get; set; }






    }
}