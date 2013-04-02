using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcWebRole.Models;

namespace MvcWebRole.Controllers
{
    public class GamePlayController : Controller
    {
        public ActionResult StartGame()
        {
            var gamePlayModel = new GamePlayModel()
                {
                    //Characters = 
                };
            

            return View(gamePlayModel);
        }

        public ActionResult AddBid(string brickId)
        {
            return new JsonResult() { };
        }
    }
}
