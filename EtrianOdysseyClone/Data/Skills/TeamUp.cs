using System.Collections.Generic;
using System.Linq;

namespace EtrianOdysseyClone.Data.Skills
{
    public class TeamUp : ISkill
    {
        public string Name { get; private set; }

        public int Duration { get; private set; }

        public TargetType TargetType { get; private set; }

        public int SkillLevel { get; private set; }

        public int TpCost { get; private set; }

        public void ExecuteSkill(ICaster caster, List<ITarget> targets)
        {
            ITarget target = targets.First();

            // Add strength to target
            target.Buffs.Add(new Buff() { StrengthModifier = caster.ActualStrength + SkillLevel, RemainingTurns = 1 });
        }

        public TeamUp()
        {
            Name = nameof(TeamUp);
            Duration = 0;
            TpCost = 5;
            SkillLevel = 1;
            TargetType = TargetType.PARTY_MEMBER;
        }
    }
}
