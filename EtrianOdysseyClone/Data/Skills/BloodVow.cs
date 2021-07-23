using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Skills
{
    public class BloodVow : ISkill
    {
        public string Name { get; private set; }

        public int Duration { get; private set; }

        public TargetType TargetType { get; private set; }

        public int TpCost { get; private set; }

        public int SkillLevel { get; private set; }

        public void ExecuteSkill(ICaster caster, List<ITarget> targets)
        {
            caster.ActualHP -= SkillLevel + 4;

            caster.Buffs.Add(new Buff()
            {
                StrengthModifier = SkillLevel + 4,
                RemainingTurns = Duration + 1 // Don't include casting turn
            });
        }

        public BloodVow()
        {
            Name = nameof(BloodVow);
            Duration = 3;
            TpCost = 3;
            SkillLevel = 1;
            TargetType = TargetType.SELF;
        }
    }
}
