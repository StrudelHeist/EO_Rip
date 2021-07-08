using System.Collections.Generic;
using System.IO;

namespace EtrianOdysseyClone.Data.Maps
{
    public class Floor1
    {
        public List<MapCell> MapLayout { get; set; }

        public Floor1()
        {
            MapLayout = new List<MapCell>();

            // TODO: Build map from text file
        }

        public void DigestMapFile(string pathToMapFile)
        {
            using (StreamReader mapFile = new StreamReader(pathToMapFile))
            {
                string line;
                while ((line = mapFile.ReadLine()) != null)
                {

                }
            }
        }
    }
}
