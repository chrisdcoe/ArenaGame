using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArenaGame.Models;
using ArenaGame.Repositories;

namespace ArenaGame.Controllers
{
    public class WeaponsController : Controller
    {
        private WeaponRepository weaponRepository;

        [HttpGet]
        public ActionResult Weapons()
        {
            weaponRepository = new WeaponRepository();
            var weapons = weaponRepository.GetAll();

            return View();
        }

        // add weapon
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWeapon(Weapon weapon)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }

            weaponRepository = new WeaponRepository();
            weaponRepository.Create(weapon);
            return RedirectToAction("Weapons");
        }

        // update weapon to the database
        [HttpGet]
        public ActionResult Edit(int id)
        {
            weaponRepository = new WeaponRepository();
            var weapon = weaponRepository.GetById(id);
            return RedirectToAction("Weapons");
        }

        [HttpPost]
        public ActionResult Edit(Weapon weapon)
        {
            weaponRepository = new WeaponRepository();
            weaponRepository.Update(weapon);
            return RedirectToAction("Weapons");
        }

        // delete weapon from the database whose id matches with specified id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            weaponRepository = new WeaponRepository();
            var weapon = weaponRepository.GetById(id);
            return View(weapon);
        }

        [HttpPost]
        public ActionResult Delete(Weapon weapon)
        {
            weaponRepository = new WeaponRepository();
            weaponRepository.Delete(weapon.ID);
            return RedirectToAction("Weapons");
        }
    }
}