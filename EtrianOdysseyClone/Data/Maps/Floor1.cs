using System.Collections.Generic;
using System.IO;

namespace EtrianOdysseyClone.Data.Maps
{
    public class Floor1 : DungeonMap
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public MapCell CurrentCell
        {
            get
            {
                return MapLayout[CurrentCellIdx];
            } 
        }
        public int CurrentCellIdx
        {
            get
            {
                return (YPosition * 10) + XPosition;
            }
        }

        public List<MapCell> MapLayout { get; set; }

        public Floor1()
        {
            MapLayout = new List<MapCell>();

            XPosition = 0;
            YPosition = 0;

            // Build map from text file
            DigestMapFile("wwwroot/MapFiles/floor1.txt");

            // Set current cell information
            MapLayout[CurrentCellIdx].PartyHere = true;
            MapLayout[CurrentCellIdx].Explored = true;
            UpdateVisionRange(true);
        }

        public void DigestMapFile(string pathToMapFile)
        {
            using (StreamReader mapFile = new StreamReader(pathToMapFile))
            {
                string line;
                while ((line = mapFile.ReadLine()) != null)
                {
                    line = line.Replace(" ", "");
                    for (int i = 0; i < line.Length; i++)
                    {
                        var mapCell = new MapCell();
                        switch (line[i])
                        {
                            case '<':
                                mapCell.SpaceType = CellType.STAIR_DOWN;
                                break;
                            case '0':
                                mapCell.SpaceType = CellType.PATH;
                                break;
                            case 'X':
                                mapCell.SpaceType = CellType.WALL;
                                break;
                            case '>':
                                mapCell.SpaceType = CellType.STAIR_UP;
                                break;
                            default:
                                break;
                        }
                        MapLayout.Add(mapCell);
                    }
                }
            }
        }

        public void MoveUp()
        {
            MoveY(-1);
        }
        public void MoveDown()
        {
            MoveY(1);
        }
        public void MoveRight()
        {
            MoveX(1);
        }
        public void MoveLeft()
        {
            MoveX(-1);
        }

        private void MoveX(int increment)
        {
            // Check if we can move down
            // --> Check if new idx is valid
            int newXPosition = XPosition + increment;
            if (newXPosition > 9 || newXPosition < 0)
                return;
            // --> Check if wall at new position
            if (MapLayout[(YPosition * 10) + newXPosition].SpaceType == CellType.WALL)
                return;

            // Have party leave previous cell
            MapLayout[CurrentCellIdx].PartyHere = false;
            UpdateVisionRange(false);

            // Update position and cell
            XPosition = newXPosition;
            MapLayout[CurrentCellIdx].PartyHere = true;
            MapLayout[CurrentCellIdx].Explored = true;

            // Add cells to vision range
            UpdateVisionRange(true);
        }
        private void MoveY(int increment)
        {
            // Check if we can move down
            // --> Check if new idx is valid
            int newYPosition = YPosition + increment;
            if (newYPosition > 9 || newYPosition < 0)
                return;
            // --> Check if wall at new position
            if (MapLayout[(newYPosition * 10) + XPosition].SpaceType == CellType.WALL)
                return;

            // Have party leave previous cell
            MapLayout[CurrentCellIdx].PartyHere = false;
            UpdateVisionRange(false);

            // Update position and cell
            YPosition = newYPosition;
            MapLayout[CurrentCellIdx].PartyHere = true;
            MapLayout[CurrentCellIdx].Explored = true;

            // Add cells to vision range
            UpdateVisionRange(true);
        }

        private void UpdateVisionRange(bool visible)
        {
            // Top left
            int topLeftY = YPosition - 1;
            int topLeftX = XPosition - 1;
            if (topLeftY >= 0 && topLeftX >= 0)
            {
                int idx = (topLeftY * 10) + topLeftX;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Top
            int topY = YPosition - 1;
            if (topY >= 0)
            {
                int idx = (topY * 10) + XPosition;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Top Right
            int topRightY = YPosition - 1;
            int topRightX = XPosition + 1;
            if (topRightY >= 0 && topRightX <= 9)
            {
                int idx = (topRightY * 10) + topRightX;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Right
            int rightX = XPosition + 1;
            if (rightX <= 9)
            {
                int idx = (YPosition * 10) + rightX;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Bottom Right
            int bottomRightX = XPosition + 1;
            int bottomRightY = YPosition + 1;
            if (bottomRightX <= 9 && bottomRightY <= 9)
            {
                int idx = (bottomRightY * 10) + bottomRightX;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Bottom
            int bottomY = YPosition + 1;
            if (bottomY <= 9)
            {
                int idx = (bottomY * 10) + XPosition;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Bottom Left
            int bottomLeftY = YPosition + 1;
            int bottomLeftX = XPosition - 1;
            if (bottomLeftY <= 9 && bottomLeftX >= 0)
            {
                int idx = (bottomLeftY * 10) + bottomLeftX;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
            // Left
            int leftX = XPosition - 1;
            if (leftX >= 0)
            {
                int idx = (YPosition * 10) + leftX;
                MapLayout[idx].InVision = visible;
                if (MapLayout[idx].SpaceType == CellType.WALL)
                    MapLayout[idx].Explored = true;
            }
        }
    }
}
