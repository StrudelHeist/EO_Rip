namespace EtrianOdysseyShared.Jobs
{
    public class Protector : IJob
    {
        public string JobTitle => "Protector";
        public string JobSubtitle => "Frontline defender+";
        public string JobDescription => "Holy knight sworn to guard others with his life. His sheild is an invaluable tool for surviving the labyrinth";

        public int StartingHP => 60;
        public int StartingTP => 52;
        public int StartingStrength => 13;
        public int StartingMagicStrength => 10;
        public int StartingDefense => 20;
        public int StartingMagicDefense => 15;
        public int StartingSpeed => 8;
        public int StartingLuck => 13;
    }
}
