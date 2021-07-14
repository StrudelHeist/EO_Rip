using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Ailment Inflictor
    public class Rogue : BaseJob
    {
        // 48 total points
        public Rogue()
        {
            JobTitle = Job.Rogue;

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
