using EtrianOdysseyShared.Jobs;

namespace EtrianOdysseyShared.Characters
{
    public class Justin : PartyMember
    {
        public Justin()
        {
            Level = 1;

            Name = nameof(Justin);

            ImagePath = "pack://application:,,,/Images/BattlePoses/JustinBattlePose.png";

            Job = new Protector();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
