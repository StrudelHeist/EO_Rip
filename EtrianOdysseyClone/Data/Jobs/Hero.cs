namespace EtrianOdysseyClone.Data.Jobs
{
    // All Around
    public class Hero : IJob
    {
        public int StartingHP { get; set; }
        public int StartingTP { get; set; }

        public int StartingStrength { get; set; }
        public int StartingMagicStrength { get; set; }
        public int StartingDefense { get; set; }
        public int StartingMagicDefense { get; set; }
        public int StartingSpeed { get; set; }
        public int StartingLuck { get; set; }

        // 48 total points
        public Hero()
        {
            StartingHP = 20;
            StartingTP = 10;

            StartingStrength = 3;
            StartingDefense = 3;

            StartingMagicStrength = 3;
            StartingMagicDefense = 3;

            StartingSpeed = 3;
            StartingLuck = 3;
        }
    }
}
