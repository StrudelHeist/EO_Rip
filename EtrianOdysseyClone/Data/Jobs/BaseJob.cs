using EtrianOdysseyClone.Data.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data.Jobs
{
    public abstract class BaseJob: IJob
    {
        public List<ISkill> Skills { get; protected set; }
        public Job JobTitle { get; protected set; }

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

