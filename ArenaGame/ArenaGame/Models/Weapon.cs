﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArenaGame.Models
{
    public class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
    }
}