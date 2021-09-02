namespace EtrianOdysseyShared.Jobs
{
    public class Harbinger : IJob
    {
        public string JobTitle => "Harbinger";
        public string JobSubtitle => "Flex ailment specialist";
        public string JobDescription => "Manipulator of miasma. He weakens foes with it, then uses his weapon to cut them down.";

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
