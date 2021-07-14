using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // All Around
    public class Hero : BaseJob
    {
        // 48 total points
        public Hero()
        {
            JobTitle = Job.Hero;

            StartingHP = 20;
            StartingTP = 10;

            StartingStrength = 3;
            StartingDefense = 3;

            StartingMagicStrength = 3;
            StartingMagicDefense = 3;

            StartingSpeed = 3;
            StartingLuck = 3;
        }
    }
}
