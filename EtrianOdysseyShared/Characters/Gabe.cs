using EtrianOdysseyShared.Jobs;

namespace EtrianOdysseyShared.Characters
{
    public class Gabe : PartyMember
    {
        public Gabe()
        {
            Level = 1;

            Name = nameof(Gabe);

            ImagePath = "pack://application:,,,/Images/BattlePoses/GabeBattlePose.png";

            Job = new Harbinger();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
