using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaceSite.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string FoodName { get; set; }
        [StringLength(200)]
        public string Explanation { get; set; }
        public int Price { get; set; }

        public ICollection<Menu> Menus { get; set; }

    }
}