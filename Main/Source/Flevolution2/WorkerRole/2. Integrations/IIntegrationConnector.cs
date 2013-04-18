﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace WorkerRole.Integration
{
    public interface IIntegrationConnector
    {
        IEnumerable<Character> GetCharacters();
    }
}
