using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Ailment Inflictor
    public class Rogue : IJob
    {
        public Job JobTitle { get { return Job.Rogue; } }
        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }

        // 48 total points
        public Rogue()
        {
            StartingHP = 12;
            StartingTP = 15;

            StartingStrength = 1;
            StartingDefense = 1;

            StartingMagicStrength = 10;
            StartingMagicDefense = 1;

            StartingSpeed = 5;
            StartingLuck = 3;
        }
    }
}
