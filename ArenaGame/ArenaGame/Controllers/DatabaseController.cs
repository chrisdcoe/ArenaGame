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



    }
}