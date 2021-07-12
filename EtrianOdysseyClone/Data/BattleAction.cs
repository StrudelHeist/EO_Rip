using System.Collections.Generic;

namespace EtrianOdysseyClone.Data
{
    public class BattleAction
    {
        public int ActionSpeed { get; set; }

        public delegate void TheAction();

        public TheAction ActualAction { get; set; }

        public string ActionInformation { get; set; }
    }
}
