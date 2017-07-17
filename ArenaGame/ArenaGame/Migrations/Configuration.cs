namespace ArenaGame.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ArenaGame.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ArenaGame.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ArenaGame.Context";
        }

        protected override void Seed(ArenaGame.Context context)
        {
            context.Weapons.AddOrUpdate(
                x => x.ID,
                new Weapon() { ID = 1, Name = "Club", Price = 5, MinDamage = 1, MaxDamage = 4 },
                new Weapon() { ID = 2, Name = "Dagger", Price = 10, MinDamage = 1, MaxDamage = 6 },
                new Weapon() { ID = 3, Name = "Longsword", Price = 25, MinDamage = 2, MaxDamage = 8 }
                
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
