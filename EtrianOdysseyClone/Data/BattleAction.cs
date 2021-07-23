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

    public enum BattleState
    {
        MEMBER_SELECT_ACTION,
        MEMBER_SELECT_SKILL,
        SELECT_TARGET_SINGLE,
        SELECT_TARGET_LINE,
        SELECT_MEMBER_SINGLE,
        SELECT_MEMBER_LINE,
        BATTLE_TIME
    }
}
