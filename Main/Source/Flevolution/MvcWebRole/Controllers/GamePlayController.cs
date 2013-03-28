using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebRole.Controllers
{
    public class GamePlayController : Controller
    {
        //
        // GET: /GamePlay/StartGame

        public ActionResult StartGame()
        {
            return View();
        }

    }
}
