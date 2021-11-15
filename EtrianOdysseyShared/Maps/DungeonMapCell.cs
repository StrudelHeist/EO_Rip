using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtrianOdysseyShared.Maps
{
    public class DungeonMapCell
    {
        public MapCellType CellType { get; private set; }

        public DungeonMapCell(char code)
        {
            CellType = GetMapCellType(code);
        }

        private MapCellType GetMapCellType(char type)
        {
            switch (type)
            {
                case 'O':
                    return MapCellType.FLOOR;
                case 'D':
                    return MapCellType.DOOR;
                case 'S':
                    return MapCellType.SHORTCUT;
                case '<':
                    return MapCellType.STAIR_DOWN;
                case '>':
                    return MapCellType.STAIR_UP;
                case 'X':
                    return MapCellType.WALL;
                default:
                    return MapCellType.DEFAULT;
            }
        }
    }
}
