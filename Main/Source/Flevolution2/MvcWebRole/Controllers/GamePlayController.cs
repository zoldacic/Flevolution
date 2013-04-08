using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using Contracts;
using Domain.Services;
using MvcWebRole.Models;

namespace MvcWebRole.Controllers
{
    public class GamePlayController : Controller
    {
        private IGameService GetGameService()
        {
            return new GameService();
        }

        public ActionResult StartGame()
        {
            var characters = GetGameService().GetCharacters();
            var gamePlayModel = new GamePlayModel()
            {
                Characters = from c in characters
                             select new CharacterModel() { 
                                 Id = c.Id,
                                 Name = c.Name
                             }
            };

            return View(gamePlayModel);
        }

        public ActionResult AddBid(string brickId)
        {
            return new JsonResult() { };
        }
    }
}
