using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Tank / Party Protector
    public class Defender : IJob
    {
        public List<ISkill> Skills { get; private set; }
        public Job JobTitle { get { return Job.Defender; } }

        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }

        public Defender()
        {
            StartingHP = 25;
            StartingTP = 7;

            StartingStrength = 1;
            StartingDefense = 5;

            StartingMagicStrength = 1;
            StartingMagicDefense = 5;

            StartingSpeed = 3;
            StartingLuck = 1;
        }
    }
}
