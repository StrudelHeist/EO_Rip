using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data
{
    public enum CellType
    {
        PATH,
        WALL,
        DAMAGE_FLOOR // Thorns, fire, etc, something that party can walk on but they'll take damage
    }

    public class MapCell
    {
        public CellType SpaceType { get; set; }

        public bool Explored { get; set; } // Whether or not the party has ever entered this cell
        public bool PartyHere { get; set; } // If party is in cell

    }
}
