using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Glass Cannon \ Damage Dealer
    public class Bushi : BaseJob
    {
        // 48 total points
        public Bushi()
        {
            JobTitle = Job.Bushi;

            StartingHP = 20;
            StartingTP = 10;

            StartingStrength = 5;
            StartingDefense = 1;

            StartingMagicStrength = 5;
            StartingMagicDefense = 1;

            StartingSpeed = 2;
            StartingLuck = 4;

            InitializeSkills();
        }

        private void InitializeSkills()
        {
            Skills = new List<ISkill>();

            Skills.Add(new BloodVow());
            Skills.Add(new HeavyBlow());
            Skills.Add(new WideSwing());
        }
    }
}
