using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Contracts;
using Domain.Integrations;

namespace Domain.Services
{
    public class GameService : IGameService
    {
        private static readonly IIntegrationConnector _connector = new RavenIntegrationConnector();
        public IEnumerable<Character> GetCharacters()
        {
            return _connector.GetCharacters();
        }
    }
}
