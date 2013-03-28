using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole.Controllers
{
    public class NewGameController : Controller
    {
        //
        // GET: /NewGame/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PlayHuman()
        {
            return RedirectToAction("StartGame", "GamePlay");
        }
    }
}
