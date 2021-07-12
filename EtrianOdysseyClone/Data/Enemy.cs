using System.Collections.Generic;

namespace EtrianOdysseyClone.Data
{
    public class Enemy : ITarget
    {
        public string Name { get; set; }
        
        public string ImagePath { get; set; }

        public int LinePosition { get; set; }

        public int BaseHP { get; set; }

        public int BaseStrength { get; set; }
        public int BaseDefense { get; set; }
        public int BaseMagicStrength { get; set; }
        public int BaseMagicDefense { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseLuck { get; set; }           // Use for crit calculation

        public int ActualHP { get; set; }
        public int ActualTP { get; set; } // Only used to implement "ITarget" enemies shouldn't use TP

        public int ActualStrength
        {
            get
            {
                int buffMods = 0;
                foreach (var buff in Buffs)
                    buffMods += buff.StrengthModifier;

                return BaseStrength + buffMods;
            }
        }
        public int ActualDefense
        {
            get
            {
                int buffMods = 0;
                foreach (var buff in Buffs)
                    buffMods += buff.DefenseModifier;

                return BaseDefense + buffMods;
            }
        }
        public int ActualMagicStrength
        {
            get
            {
                int buffMods = 0;
                foreach (var buff in Buffs)
                    buffMods += buff.MagicStrengthModifier;

                return BaseMagicStrength + buffMods;
            }
        }
        public int ActualMagicDefense
        {
            get
            {
                int buffMod = 0;
                foreach (var buff in Buffs)
                    buffMod += buff.MagicDefenseModifier;

                return BaseMagicDefense + buffMod;
            }
        }
        public int ActualSpeed
        {
            get
            {
                int buffMods = 0;
                foreach (var buff in Buffs)
                    buffMods += buff.SpeedModifier;

                return BaseSpeed + buffMods;
            }
        }
        public int ActualLuck
        {
            get
            {
                int buffMods = 0;
                foreach (var buff in Buffs)
                    buffMods += buff.LuckModifier;

                return BaseLuck + buffMods;
            }
        }

        public List<Buff> Buffs { get; set; }
    }
}
