using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Skills
{
    public interface ISkill
    {
        public string Name { get; }

        public TargetType TargetType { get; }

        // What happens (increase/decrease stats)
        public void ExecuteSkill(ICaster caster, List<ITarget> targets);

        // Duration - how long does the effect last
        public int Duration { get; }

        public int SkillLevel { get; }

        // TP Cost
        public int TpCost { get; }
    }
}
