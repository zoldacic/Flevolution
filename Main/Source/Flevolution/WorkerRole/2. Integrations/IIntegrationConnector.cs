using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerRole.X._ServiceModels;

namespace WorkerRole.Integration
{
    public interface IIntegrationConnector
    {
        IEnumerable<Character> GetCharacters();
    }
}
