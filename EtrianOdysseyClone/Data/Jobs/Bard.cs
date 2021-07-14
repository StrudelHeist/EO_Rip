using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Healer / Enhance Party Stats
    public class Bard : BaseJob, IJob
    {
        public Bard()
        {
            JobTitle = Job.Bard;

            StartingHP = 10;
            StartingTP = 20;

            StartingStrength = 1;
            StartingDefense = 1;

            StartingMagicStrength = 7;
            StartingMagicDefense = 3;

            StartingSpeed = 3;
            StartingLuck = 3;
        }
    }
}
