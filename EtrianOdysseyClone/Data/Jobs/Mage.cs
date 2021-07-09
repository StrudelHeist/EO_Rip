using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Elemental Attacker
    public class Mage : IJob
    {
        public List<ISkill> Skills { get; private set; }

        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }

        public Mage()
        {
            StartingHP = 12;
            StartingTP = 10;

            StartingStrength = 1;
            StartingDefense = 1;

            StartingMagicStrength = 11;
            StartingMagicDefense = 7;

            StartingSpeed = 3;
            StartingLuck = 3;
        }
    }
}
