﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Contracts
{
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        IEnumerable<Character> GetCharacters();
    }
}
