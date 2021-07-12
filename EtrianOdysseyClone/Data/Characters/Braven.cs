using EtrianOdysseyClone.Data.Jobs;

namespace EtrianOdysseyClone.Data.Characters
{
    public class Braven : PartyMember
    {
        public Braven(int linePosition)
        {
            LinePosition = linePosition;

            Level = 1;

            Name = nameof(Braven);

            ImagePath = "https://i.imgur.com/QdV0wZJ.png";

            Job = new Bushi();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
