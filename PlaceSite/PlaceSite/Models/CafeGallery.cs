using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaceSite.Models
{
    public class CafeGallery
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Img { get; set; }

        public virtual CafeGallery CafeGallery_Id { get; set; }
    }
}