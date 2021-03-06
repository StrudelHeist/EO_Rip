using System.Collections.Generic;

namespace EtrianOdysseyClone.Data
{
    public interface ITarget
    {
        public int ActualHP { get; set; }
        public int ActualTP { get; set; }

        public int ActualDefense { get; }

        public List<Buff> Buffs { get; set; }
    }
}
