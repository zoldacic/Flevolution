﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkerRole.X._ServiceModels;

namespace WorkerRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGameService" in both code and config file together.
    [ServiceContract]
    public interface IGameService
    {
        [OperationContract]
        IEnumerable<Character> GetCharacters();
    }
}
