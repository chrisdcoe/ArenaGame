using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArenaGame.Models;

namespace ArenaGame.Repositories
{
    public class WeaponRepository
    {
        public void Create(Weapon weapon)
        {
            using (var context = new Context())
            {
                context.Weapons.Add(weapon);

                context.SaveChanges();
            }
        }

        public void Update(Weapon weapon)
        {
            using (var context = new Context())
            {
                var weaponToUpdate = context.Weapons.Find(weapon.ID);
                weaponToUpdate.Price = weapon.Price;
                weaponToUpdate.MinDamage = weapon.MinDamage;
                weaponToUpdate.MaxDamage = weapon.MaxDamage;

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new Context())
            {
                var weaponToRemove = context.Weapons.Find(id);
                context.Weapons.Remove(weaponToRemove);

                context.SaveChanges();
            }
        }

        public List<Weapon> GetAll()
        {
            List<Weapon> weapons = new List<Weapon>();
            using (var context = new Context())
            {
                weapons = context.Weapons.ToList();
            }

            return weapons;
        }

        public Weapon GetById(int id)
        {
            Weapon weapon = null;
            using (var context = new Context())
            {
                weapon = context.Weapons.Find(id);
            }

            return weapon;
        }
    }
}