namespace EtrianOdysseyShared.Jobs
{
    public class Imperial : IJob
    {
        public string JobTitle => "Imperial";
        public string JobSubtitle => "Frontline offense+";
        public string JobDescription => "Loyal knight who uses a unique drive blade. Attacks with it can be devestating, but place a heavy burden on its inner workings.";

        public int StartingHP => 58;
        public int StartingTP => 30;
        public int StartingStrength => 18;
        public int StartingMagicStrength => 12;
        public int StartingDefense => 18;
        public int StartingMagicDefense => 12;
        public int StartingSpeed => 7;
        public int StartingLuck => 9;
    }
}
