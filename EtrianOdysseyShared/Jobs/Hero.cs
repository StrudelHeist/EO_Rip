namespace EtrianOdysseyShared.Jobs
{
    public class Hero : IJob
    {
        public string JobTitle => "Hero";
        public string JobSubtitle => "Frontline offense/defense";
        public string JobDescription => "Determined warrior of the sword and shield. He not only aides the party, but delivers raging blows seemingly beyond a normal person's capabilites.";

        public int StartingHP => 56;
        public int StartingTP => 47;
        public int StartingStrength => 15;
        public int StartingMagicStrength => 12;
        public int StartingDefense => 17;
        public int StartingMagicDefense => 16;
        public int StartingSpeed => 15;
        public int StartingLuck => 9;
    }
}
