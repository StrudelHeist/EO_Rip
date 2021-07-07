namespace EtrianOdysseyClone.Data.Jobs
{
    // Healer / Enhance Party Stats
    public class Bard : IJob
    {
        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }

        public Bard()
        {
            StartingHP = 10;
            StartingTP = 20;

            StartingStrength = 1;
            StartingDefense = 1;

            StartingMagicStrength = 7;
            StartingMagicDefense = 3;

            StartingSpeed = 3;
            StartingLuck = 3;
        }
    }
}
