using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtrianOdysseyClone.Data.Debuffs
{
    public interface IDebuff
    {
        // TODO: Remaining turn count?
        public int StrengthModifier { get; set; }
        public int MagicStrengthModifier { get; set; }
        public int DefenseModifier { get; set; }
        public int MagicDefenseModifier { get; set; }
        public int SpeedModifier { get; set; }
        public int LuckModifier { get; set; }
    }
}
