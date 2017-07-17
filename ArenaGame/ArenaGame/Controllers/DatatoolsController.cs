using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArenaGame.Models;

namespace ArenaGame.Controllers
{
    public class DatatoolsController : Controller
    {
        [HttpGet]
        public ActionResult Weapons()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Weapon std)
        {
            // update weapon to the database

            return RedirectToAction("Weapons");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete weapon from the database whose id matches with specified id

            return RedirectToAction("Weapons");
        }

    }
}