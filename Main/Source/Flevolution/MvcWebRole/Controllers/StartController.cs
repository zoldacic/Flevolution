using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewGame()
        {
            return RedirectToAction("Index", "NewGame");
        }
    }
}
