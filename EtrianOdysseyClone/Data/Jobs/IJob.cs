using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data.Jobs
{
    public interface IJob
    {
        // TODO: List of skills for job
        // TODO: Level up method (different classes/jobs should level up differently)

        // Starting stats per job
        public Job JobTitle { get; }
        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }
    }
}
