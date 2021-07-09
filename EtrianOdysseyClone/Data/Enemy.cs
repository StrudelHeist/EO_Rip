using EtrianOdysseyClone.Data.Buffs;
using EtrianOdysseyClone.Data.Debuffs;
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

        public int ActualStrength
        {
            get
            {
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.StrengthModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.StrengthModifier;

                return BaseStrength + buffMods + debuffMods;
            }
        }
        public int ActualDefense
        {
            get
            {
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.DefenseModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.DefenseModifier;

                return BaseDefense + buffMods + debuffMods;
            }
        }
        public int ActualMagicStrength
        {
            get
            {
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.MagicStrengthModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.MagicStrengthModifier;

                return BaseMagicStrength + buffMods + debuffMods;
            }
        }
        public int ActualMagicDefense
        {
            get
            {
                int buffMod = 0;
                foreach (IBuff buff in Buffs)
                    buffMod += buff.MagicDefenseModifier;
                int debuffMod = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMod += debuff.MagicDefenseModifier;

                return BaseMagicDefense + buffMod + debuffMod;
            }
        }
        public int ActualSpeed
        {
            get
            {
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.SpeedModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.SpeedModifier;

                return BaseSpeed + buffMods + debuffMods;
            }
        }
        public int ActualLuck
        {
            get
            {
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.LuckModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.LuckModifier;

                return BaseLuck + buffMods + debuffMods;
            }
        }

        public List<IBuff> Buffs { get; set; }
        public List<IDebuff> Debuffs { get; set; }
    }
}
