namespace EtrianOdysseyShared.Jobs
{
    public class Medic : IJob
    {
        public string JobTitle => nameof(Medic);
        public string JobSubtitle => "Backline healer";
        public string JobDescription => "Healer who treats the party's wounds. His combat skill is limited, but he is highly useful regardless";

        public int StartingHP => 54;
        public int StartingTP => 57;
        public int StartingStrength => 14;
        public int StartingMagicStrength => 15;
        public int StartingDefense => 16;
        public int StartingMagicDefense => 18;
        public int StartingSpeed => 13;
        public int StartingLuck => 16;
    }
}
