using EtrianOdysseyShared;
using EtrianOdysseyWpf.View;

namespace EtrianOdysseyWpf
{
    public class TransitionMessage
    {
        public AvailableViews RequestedView { get; set; }
        public GameSession SessionInformation { get; set; }
    }
}
