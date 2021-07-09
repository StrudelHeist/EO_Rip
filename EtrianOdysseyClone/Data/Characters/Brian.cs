using EtrianOdysseyClone.Data.Jobs;

namespace EtrianOdysseyClone.Data.Characters
{
    public class Brian : PartyMember
    {
        public Brian(int linePosition)
        {
            LinePosition = linePosition;

            Level = 1;

            Name = nameof(Brian);

            ImagePath = "https://i.imgur.com/0QGrZBa.png";

            Job = new Hero();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
