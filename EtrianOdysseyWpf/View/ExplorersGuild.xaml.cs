using EtrianOdysseyShared;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace EtrianOdysseyWpf.View
{
    /// <summary>
    /// Interaction logic for ExplorersGuild.xaml
    /// </summary>
    public partial class ExplorersGuild : UserControl, IGameView
    {
        private GameSession _session;

        public event EventHandler<TransitionMessage> NewViewRequested;
        public event PropertyChangedEventHandler PropertyChanged;

        public ExplorersGuild()
        {
            DataContext = this;
            InitializeComponent();
        }

        public void Setup(GameSession session)
        {
            _session = session;
        }

        private void RegisterClicked(object sender, RoutedEventArgs e)
        {
            NewViewRequested?.Invoke(this, new TransitionMessage{
                RequestedView = AvailableViews.HERO_REGISTRATION,
                SessionInformation = _session
            });
        }
        private void LeaveClicked(object sender, RoutedEventArgs e)
        {
            NewViewRequested?.Invoke(this, new TransitionMessage{
                RequestedView = AvailableViews.TOWN_SQUARE,
                SessionInformation = _session
            });
        }
    }
}
