using EtrianOdysseyClone.Data.Buffs;
using EtrianOdysseyClone.Data.Debuffs;
using EtrianOdysseyClone.Data.Items.Armor;
using EtrianOdysseyClone.Data.Items.Weapons;
using EtrianOdysseyClone.Data.Jobs;
using System.Collections.Generic;

namespace EtrianOdysseyClone.Data
{
    public class PartyMember : ITarget
    {
        public string Name { get; set; }

        public string ImagePath { get; set; }

        public int LinePosition;

        public IJob Job { get; set; }

        public int Level { get; set; }
        public int ExpToNextLevelUp { get; set; }

        public int BaseHP { get; set; }
        public int BaseTP { get; set; }

        public int BaseStrength { get; set; }
        public int BaseDefense { get; set; }
        public int BaseMagicStrength { get; set; }
        public int BaseMagicDefense { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseLuck { get; set; }           // Use for crit calculation

        public int ActualHP { get; set; }
        public int ActualTP { get; set; }

        public int ActualStrength
        {
            get
            {
                int weaponMods = 0;
                foreach (IWeapon weapon in EquippedWeapons)
                    weaponMods += weapon.AttackModifier;
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.StrengthModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.StrengthModifier;

                return BaseStrength + weaponMods + buffMods + debuffMods;
            }
        }
        public int ActualDefense
        {
            get
            {
                int armorMods = 0;
                foreach (IArmor armor in EquippedArmor)
                    armorMods += armor.DefenseModifier;
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.DefenseModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.DefenseModifier;

                return BaseDefense + armorMods + buffMods + debuffMods;
            }
        }
        public int ActualMagicStrength
        {
            get
            {
                int weaponMods = 0;
                foreach (IWeapon weapon in EquippedWeapons)
                    weaponMods += weapon.MagicAttackModifier;
                int buffMods = 0;
                foreach (IBuff buff in Buffs)
                    buffMods += buff.MagicStrengthModifier;
                int debuffMods = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMods += debuff.MagicStrengthModifier;

                return BaseMagicStrength + weaponMods + buffMods + debuffMods;
            }
        }
        public int ActualMagicDefense
        {
            get
            {
                int armorMod = 0;
                foreach (IArmor armor in EquippedArmor)
                    armorMod += armor.MagicDefenseModifier;
                int buffMod = 0;
                foreach (IBuff buff in Buffs)
                    buffMod += buff.MagicDefenseModifier;
                int debuffMod = 0;
                foreach (IDebuff debuff in Debuffs)
                    debuffMod += debuff.MagicDefenseModifier;

                return BaseMagicDefense + armorMod + buffMod + debuffMod;
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

        public List<IWeapon> EquippedWeapons { get; set; }
        public List<IArmor> EquippedArmor { get; set; }

        public List<IBuff> Buffs { get; set; }
        public List<IDebuff> Debuffs { get; set; }

        protected void InitializeStats()
        {
            BaseHP = Job.StartingHP;
            BaseTP = Job.StartingTP;

            ActualHP = Job.StartingHP;
            ActualTP = Job.StartingTP;

            BaseStrength = Job.StartingStrength;
            BaseDefense = Job.StartingDefense;
            BaseMagicStrength = Job.StartingMagicStrength;
            BaseMagicDefense = Job.StartingMagicDefense;
            BaseSpeed = Job.StartingSpeed;
            BaseLuck = Job.StartingLuck;
        }
        protected void InitializeEquipment()
        {
            EquippedArmor = new List<IArmor>();
            EquippedWeapons = new List<IWeapon>();
            Buffs = new List<Buffs.IBuff>();
            Debuffs = new List<Debuffs.IDebuff>();

            EquippedArmor.Add(new ButtonUpShirt());
            EquippedWeapons.Add(new Keyboard());
        }
    }
}
