using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Elemental Attacker
    public class Mage : BaseJob
    {
        public Mage()
        {
            JobTitle = Job.Mage;

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
