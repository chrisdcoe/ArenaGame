using ArenaGame.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArenaGame
{
    public class Context : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
    }
}
