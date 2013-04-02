using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebRole.Models
{
    public class GamePlayModel
    {
        public IEnumerable<CharacterModel> Characters { get; set; }

        public GamePlayModel()
        {

        }
    }
}