using EtrianOdysseyClone.Data.Skills;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Jobs
{
    // Glass Cannon \ Damage Dealer
    public class Bushi : IJob
    {
        public List<ISkill> Skills { get; private set; }

        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }

        // 48 total points
        public Bushi()
        {
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
