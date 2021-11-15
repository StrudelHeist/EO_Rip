using EtrianOdysseyShared.Maps;

namespace EtrianOdysseyShared
{
    public class GameSession
    {
        private DungeonMap _currentMap;

        public Party Party { get; set; }
        public DungeonMap CurrentMap
        {
            get
            {
                if (_currentMap == null)
                {
                    // Build new map
                    _currentMap = new DungeonMap(Properties.Resources.B01F);
                }
                return _currentMap;
            }
            set
            {
                _currentMap = value;
            }
        }

        public GameSession()
        {
            Party = new Party();
        }
    }
}
