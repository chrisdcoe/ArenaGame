using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArenaGame.Models
{
    public class Enemy : Creature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDamage { get; set; }
        public int GainExp { get; set; }
        public int GainGold { get; set; }
    }
}