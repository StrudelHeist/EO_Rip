namespace EtrianOdysseyShared
{
    public class Party
    {
        private const int MAX_PARTY_SLOTS = 6;

        private PartyMember[] _partyMembers;

        public Party()
        {
            _partyMembers = new PartyMember[MAX_PARTY_SLOTS];
        }

        /// <summary>
        /// Add member to party
        /// </summary>
        /// <param name="member">Party member</param>
        /// <param name="slot">Slot 1-6</param>
        public void AddPartyMember(PartyMember member, int slot)
        {
            if (slot > MAX_PARTY_SLOTS)
                return;

            _partyMembers[slot - 1] = member;
        }
        /// <summary>
        /// Get party member
        /// </summary>
        /// <param name="slot">Slot 1-6</param>
        /// <returns></returns>
        public PartyMember GetPartyMember(int slot)
        {
            if (slot > MAX_PARTY_SLOTS) return null;

            return _partyMembers[slot - 1];
        }
    }
}
