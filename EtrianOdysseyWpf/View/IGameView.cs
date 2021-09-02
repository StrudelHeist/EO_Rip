using EtrianOdysseyShared;
using System;
using System.ComponentModel;

namespace EtrianOdysseyWpf.View
{
    public interface IGameView : INotifyPropertyChanged
    {
        event EventHandler<TransitionMessage> NewViewRequested;

        void Setup(GameSession session);
    }
}
