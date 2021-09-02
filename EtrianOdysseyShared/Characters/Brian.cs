using EtrianOdysseyShared.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtrianOdysseyShared.Characters
{
    public class Brian : PartyMember
    {
        public Brian()
        {
            Level = 1;

            Name = nameof(Brian);

            ImagePath = "pack://application:,,,/Images/BattlePoses/BrianBattlePose.png";

            Job = new Hero();

            InitializeStats();
            InitializeEquipment();
        }
    }
}
