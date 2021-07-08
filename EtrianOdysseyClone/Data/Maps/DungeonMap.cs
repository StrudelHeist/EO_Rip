using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Maps
{
    public interface DungeonMap
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public MapCell CurrentCell { get; }

        public List<MapCell> MapLayout { get; set; }

        public void MoveUp();
        public void MoveDown();
        public void MoveRight();
        public void MoveLeft();
    }
}
