using System.Collections.Generic;

namespace EtrianOdysseyClone.Data
{
    public class Party
    {
        public List<PartyMember> Members { get; set; }

        public Party()
        {
            Members = new List<PartyMember>();
        }
    }
}
