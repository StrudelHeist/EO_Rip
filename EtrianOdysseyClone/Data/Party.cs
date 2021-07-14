namespace EtrianOdysseyClone.Data
{
    public class Party
    {
        public PartyMember[] AllMembers { get; private set; }

        public int Count
        {
            get
            {
                int totalCount = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (AllMembers[i] != null)
                        totalCount++;
                }
                return totalCount;
            }
        }
        public FormationPosition FinalPosition
        {
            get
            {
                int finalPosition = 0;
                for(int i = 0; i < 6; i++)
                {
                    if (AllMembers[i] != null)
                        finalPosition = i;
                }

                return (FormationPosition)finalPosition;
            }
        }

        public Party()
        {
            AllMembers = new PartyMember[6];
        }

        public PartyMember GetAtRelativePosition(int relativeIdx)
        {
            int calculatedIdx = -1;
            for(int i = 0; i < 6; i++)
            {
                if (AllMembers[i] != null)
                    calculatedIdx++;
                if (calculatedIdx == relativeIdx)
                    return AllMembers[i];
            }

            return null;
        }
        public PartyMember GetAtPosition(FormationPosition position)
        {
            return AllMembers[(int)position];
        }
        public void AddPartyMember(PartyMember member, FormationPosition position)
        {
            AllMembers[(int)position] = member;
        }

        public void RestoreParty()
        {
            for(int i = 0; i < 6; i++)
            {
                AllMembers[i].ActualHP = AllMembers[i].BaseHP;
                AllMembers[i].ActualTP = AllMembers[i].BaseTP;
            }
        }
    }
}
