using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Tank / Party Protector
    public class Defender : BaseJob
    {
        public Defender()
        {
            JobTitle = Job.Defender;

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
