using System.Collections.Generic;

namespace EtrianOdysseyClone.Data
{
    public interface ICaster
    {
        public int ActualTP { get; set; }
        public int ActualHP { get; set; }

        public int ActualStrength { get; }

        public List<Buff> Buffs { get; set; }
    }
}
