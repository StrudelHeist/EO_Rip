using System.Collections.Generic;

namespace EtrianOdysseyClone.Data.Enemies
{
    public class FatChicken : Enemy
    {
        public FatChicken(int linePosition)
        {
            LinePosition = linePosition;

            Name = nameof(FatChicken);
            ImagePath = "https://i.imgur.com/G4vWdzd.png";

            BaseHP = 30;

            BaseStrength = 10;
            BaseDefense = 2;
            BaseMagicStrength = 0;
            BaseMagicDefense = 1;

            BaseSpeed = 3;
            BaseLuck = 1;

            Buffs = new List<Buff>();
        }

        public PartyMember AttackPartyMember(PartyMember member)
        {
            // TODO: Consider line positions for attacking

            // If party member's defense is >= our strength, attack doesn't do anything
            if (member.ActualDefense >= ActualStrength)
                return member;

            member.ActualHP -= ActualStrength - member.ActualDefense;
            return member;
        }
    }
}
