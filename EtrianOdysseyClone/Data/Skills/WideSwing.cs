using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Skills
{
    public class WideSwing : ISkill
    {
        public string Name { get; private set; }

        public int Duration { get; private set; }

        public int SkillLevel { get; private set; }

        public int TpCost { get; private set; }

        public WideSwing()
        {
            Name = nameof(WideSwing);
            Duration = 0;
            TpCost = 5;
            SkillLevel = 1;
        }

        public void ExecuteSkill(ICaster caster, List<ITarget> targets)
        {
            caster.ActualTP -= TpCost;

            foreach (ITarget target in targets)
            {
                target.ActualHP -= CalculateDamageToTarget(caster, target);
            }
        }

        private int CalculateDamageToTarget(ICaster caster, ITarget target)
        {
            int targetDefense = target.ActualDefense;
            int casterAttack = caster.ActualStrength + (SkillLevel * 2);

            if (targetDefense >= casterAttack)
                return 0;
            return casterAttack - targetDefense;
        }
    }
}
