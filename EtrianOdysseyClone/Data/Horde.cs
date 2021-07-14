namespace EtrianOdysseyClone.Data
{
    public class Horde
    {
        public Enemy[] AllEnemies { get; private set; }

        public int Count
        {
            get
            {
                int totalCount = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (AllEnemies[i] != null)
                        totalCount++;
                }
                return totalCount;
            }
        }

        public Horde()
        {
            AllEnemies = new Enemy[6];
        }

        public Enemy GetAtRelativePosition(int relativeIdx)
        {
            int calculatedIdx = -1;
            for (int i = 0; i < 6; i++)
            {
                if (AllEnemies[i] != null)
                    calculatedIdx++;
                if (calculatedIdx == relativeIdx)
                    return AllEnemies[i];
            }

            return null;
        }
        public Enemy GetAtPosition(FormationPosition position)
        {
            return AllEnemies[(int)position];
        }
        public void AddEnemy(Enemy member, FormationPosition position)
        {
            AllEnemies[(int)position] = member;
        }

    }
}
