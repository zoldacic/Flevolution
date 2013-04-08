using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Contracts
{
    public interface IGameService
    {
        IEnumerable<Character> GetCharacters();
    }
}
