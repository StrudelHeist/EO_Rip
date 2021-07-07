using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data
{
    public class GameSession
    {
        public OverworldLocation CurrentLocation { get; set; }
        public int Monies { get; set; }
        public Party Party { get; set; }


        public GameSession()
        {
            CurrentLocation = OverworldLocation.MainMenu;
        }
        // TODO: Map data

        // TODO: Quest data
    }
}
