using EtrianOdysseyShared.Jobs;

namespace EtrianOdysseyShared.Characters
{
    public class Jacob : PartyMember
    {
        public Jacob()
        {
            Level = 1;

            Name = nameof(Jacob);

            ImagePath = "pack://application:,,,/Images/BattlePoses/JacobBattlePose.png";

            Job = new Medic();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
