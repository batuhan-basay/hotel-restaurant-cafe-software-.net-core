using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaceSite.Models
{
    public class HotelComment
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UserName { get; set; }
        [StringLength(200)]
        public string UserComment { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Mail { get; set; }
        public DateTime Date { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}