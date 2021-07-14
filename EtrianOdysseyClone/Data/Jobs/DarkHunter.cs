using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data.Jobs
{
    public class DarkHunter : BaseJob
    {
        public DarkHunter()
        {
            JobTitle = Job.DarkHunter;

            StartingHP = 20;
            StartingTP = 10;

            StartingStrength = 5;
            StartingDefense = 1;

            StartingMagicStrength = 5;
            StartingMagicDefense = 1;

            StartingSpeed = 2;
            StartingLuck = 4;
        }
    }
}
