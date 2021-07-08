using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data
{
    public class GameSession
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private OverworldLocation _currentLocation { get; set; }

        public OverworldLocation CurrentLocation 
        {
            get { return _currentLocation; }
            set 
            {
                _currentLocation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentLocation)));
            }
        }
        public int Monies { get; set; }
        public Party Party { get; set; }
        
        public GameSession()
        {
            CurrentLocation = OverworldLocation.Guild;
        }
        // TODO: Map data

        // TODO: Quest data
    }
}
