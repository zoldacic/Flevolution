using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Contracts;
using WorkerRole.Integration;

namespace WorkerRole
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class GameService : IGameService
    {
        private static IIntegrationConnector _connector = new RavenIntegrationConnector();
        public IEnumerable<Character> GetCharacters()
        {
            return _connector.GetCharacters();
        }
    }
}
