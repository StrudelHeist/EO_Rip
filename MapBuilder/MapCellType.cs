using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapBuilder
{
    public enum MapCellType
    {
        DEFAULT,
        FLOOR,
        WALL,
        DOOR,
        SHORTCUT,
        STAIR_UP,
        STAIR_DOWN,
        WARP_POINT,
        HAZARD
    }
}
