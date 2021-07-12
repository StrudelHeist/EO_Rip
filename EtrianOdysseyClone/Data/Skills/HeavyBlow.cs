using System.Collections.Generic;
using System.Linq;

namespace EtrianOdysseyClone.Data.Skills
{
    public class HeavyBlow : ISkill
    {
        public string Name { get; private set; }

        public int Duration { get; private set; }

        public int SkillLevel { get; private set; }

        public int TpCost { get; private set; }

        public void ExecuteSkill(ICaster caster, List<ITarget> targets)
        {
            // Should only impact one target
            ITarget target = targets.First();

            caster.ActualTP -= TpCost;

            // Calculate damage to target
            target.ActualHP -= CalculateDamageToTarget(caster, target);
        }

        public HeavyBlow()
        {
            Name = nameof(HeavyBlow);
            Duration = 0;
            TpCost = 3;
            SkillLevel = 1;
        }

        private int CalculateDamageToTarget(ICaster caster, ITarget target)
        {
            int targetDefense = target.ActualDefense;
            int casterAttack = caster.ActualStrength + (SkillLevel * 3);

            if (targetDefense >= casterAttack)
                return 0;
            return casterAttack - targetDefense;
        }
    }
}
