namespace EtrianOdysseyShared
{
    public interface IJob
    {
        // TODO: List of skills for job
        //public List<ISkill> Skills { get; }

        // TODO: Level up method (different classes/jobs should level up differently)

        // Starting stats per job
        public string JobTitle { get; }

        public string JobSubtitle { get; }
        public string JobDescription { get; }

        public int StartingHP { get;  }
        public int StartingTP { get; }

        public int StartingStrength { get; }
        public int StartingMagicStrength { get; }
        public int StartingDefense { get; }
        public int StartingMagicDefense { get; }
        public int StartingSpeed { get; }
        public int StartingLuck { get; }
    }
}
