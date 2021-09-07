namespace EtrianOdysseyShared
{
    public class GameSession
    {
        public Party Party { get; set; }

        public GameSession()
        {
            Party = new Party();
        }
    }
}
