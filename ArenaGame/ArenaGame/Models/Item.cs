using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArenaGame.Models
{
    public class Item
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Please enter a name for the weapon.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the weapon's price as an integer.")]
        public int Price { get; set; }
    }
}