using EtrianOdysseyShared;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace EtrianOdysseyWpf.View
{
    /// <summary>
    /// Interaction logic for TownView.xaml
    /// </summary>
    public partial class TownView : UserControl, IGameView
    {
        private GameSession _session;

        public event EventHandler<TransitionMessage> NewViewRequested;
        public event PropertyChangedEventHandler PropertyChanged;

        public TownView()
        {
            InitializeComponent();
        }

        public void Setup(GameSession session)
        {
            _session = session;
        }

        private void GuildClicked(object sender, RoutedEventArgs e)
        {
            NewViewRequested?.Invoke(this, new TransitionMessage
            {
                SessionInformation = _session,
                RequestedView = AvailableViews.GUILD_HOUSE
            });
        }

    }
}
