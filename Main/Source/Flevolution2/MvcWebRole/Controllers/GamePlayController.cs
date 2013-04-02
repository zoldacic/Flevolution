using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using Contracts;
using MvcWebRole.Models;

namespace MvcWebRole.Controllers
{
    public class GamePlayController : Controller
    {
        private string serviceUrl = "net.tcp://127.255.0.1:9001/GameService";

        private IGameService GetAProxy()
        {
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            EndpointAddress endpointAddress = new EndpointAddress(serviceUrl);

            var factory = new ChannelFactory<IGameService>(binding, endpointAddress).CreateChannel();
            return factory;
        }

        public ActionResult StartGame()
        {
            var characters = GetAProxy().GetCharacters();
            var gamePlayModel = new GamePlayModel()
            {
                
            };

            return View(gamePlayModel);
        }

        public ActionResult AddBid(string brickId)
        {
            return new JsonResult() { };
        }
    }
}
