using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArenaGame.Models
{
    public class Weapon : Item
    {
        [Required(ErrorMessage ="Please enter the minimum damage value of the weapon as an integer.")]
        public int MinDamage { get; set; }

        [Required(ErrorMessage = "Please enter the maximum damage value of the weapon as an integer.")]
        public int MaxDamage { get; set; }        
    }
}