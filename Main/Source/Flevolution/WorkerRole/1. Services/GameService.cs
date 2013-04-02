using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkerRole.Integration;
using WorkerRole.X._ServiceModels;

namespace WorkerRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GameService" in both code and config file together.
    public class GameService : IGameService
    {
        private static IIntegrationConnector _connector = new RavenIntegrationConnector();
        public IEnumerable<Character> GetCharacters()
        {
            return _connector.GetCharacters();
        }
    }
}
