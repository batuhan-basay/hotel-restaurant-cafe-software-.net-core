using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaceSite.Models
{
    public class Price
    {

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string RoomName { get; set; }
        public int RoomPrice { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
        public virtual Price Pricess { get; set; }

    }
}