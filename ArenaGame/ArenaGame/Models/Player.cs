using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ArenaGame.Models
{
    public class Player : Creature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

    }
}