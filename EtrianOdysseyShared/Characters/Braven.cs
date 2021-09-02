using EtrianOdysseyShared.Jobs;

namespace EtrianOdysseyShared.Characters
{
    public class Braven : PartyMember
    {
        public Braven()
        {
            Level = 1;

            Name = nameof(Braven);

            ImagePath = "pack://application:,,,/Images/BattlePoses/BravenBattlePose.png";

            Job = new Imperial();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
