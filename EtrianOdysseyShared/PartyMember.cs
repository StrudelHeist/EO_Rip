using System;
using System.Collections.Generic;

namespace EtrianOdysseyShared
{
    public class PartyMember
    {
        private int _actualTP;

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
        public int ActualTP
        {
            get
            {
                return _actualTP;
            }
            set
            {
                Console.WriteLine($"Someone is setting {Name}'s TP to {value}");
                _actualTP = value;
            }
        }

        public int ActualStrength
        {
            get
            {
                int weaponMods = 0;
                foreach (IWeapon weapon in EquippedWeapons)
                    weaponMods += weapon.AttackModifier;
                int buffMods = 0;
                foreach (var buff in Buffs)
                    buffMods += buff.StrengthModifier;

                return BaseStrength + weaponMods + buffMods;
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
                foreach (var buff in Buffs)
                    buffMods += buff.DefenseModifier;

                return BaseDefense + armorMods + buffMods;
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
                foreach (var buff in Buffs)
                    buffMods += buff.MagicStrengthModifier;

                return BaseMagicStrength + weaponMods + buffMods;
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
                foreach (var buff in Buffs)
                    buffMod += buff.MagicDefenseModifier;

                return BaseMagicDefense + armorMod + buffMod;
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

        public List<IWeapon> EquippedWeapons { get; set; }
        public List<IArmor> EquippedArmor { get; set; }

        public List<Buff> Buffs { get; set; } // Store buffs AND debuffs

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
            Buffs = new List<Buff>();

            //EquippedArmor.Add(new ButtonUpShirt());
            //EquippedWeapons.Add(new Keyboard());
        }
    }
}
