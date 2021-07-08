using EtrianOdysseyClone.Data.Maps;
using System.Collections.Generic;
using System.ComponentModel;

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
            CurrentLocation = OverworldLocation.Town;

            Maps = new List<DungeonMap>();
            Maps.Add(new Floor1());

            CurrentFloor = Maps[0];
        }

        // Map data
        public DungeonMap CurrentFloor { get; set; }
        public List<DungeonMap> Maps { get; set; }

        // TODO: Quest data
    }
}
