using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtrianOdysseyShared.Maps
{
    public class DungeonMap
    {
        public int MapSize { get { return Length * Width; } }
        public int Length { get; private set; }
        public int Width { get; private set; }

        public List<DungeonMapCell> MapCells { get; set; }

        public int PartyXPosition = 0;
        public int PartyYPosition = 0;

        public DungeonMap(string rawText)
        {
            MapCells = new List<DungeonMapCell>();
            Length = 30;
            Width = 30;

            rawText = rawText.Replace("\r\n", "");

            for(int i = 0; i < rawText.Length; i++)
            {
                char cellCode = rawText[i];
                var newCell = new DungeonMapCell(cellCode);
                MapCells.Add(newCell);
            }
        }
    }
}
