using EtrianOdysseyShared;
using EtrianOdysseyWpf.View.Secondary;
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

        private CharacterBarView _slot1View;
        private CharacterBarView _slot2View;
        private CharacterBarView _slot3View;
        private CharacterBarView _slot4View;
        private CharacterBarView _slot5View;
        private CharacterBarView _slot6View;

        public CharacterBarView Slot1View
        {
            get { return _slot1View; }
            set
            {
                _slot1View = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot1View)));
            }
        }
        public CharacterBarView Slot2View
        {
            get { return _slot2View; }
            set
            {
                _slot2View = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot2View)));
            }
        }
        public CharacterBarView Slot3View
        {
            get { return _slot3View; }
            set
            {
                _slot3View = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot3View)));
            }
        }
        public CharacterBarView Slot4View
        {
            get { return _slot4View; }
            set
            {
                _slot4View = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot4View)));
            }
        }
        public CharacterBarView Slot5View
        {
            get { return _slot5View; }
            set
            {
                _slot5View = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot5View)));
            }
        }
        public CharacterBarView Slot6View
        {
            get { return _slot6View; }
            set
            {
                _slot6View = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot6View)));
            }
        }

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

            if (_session.Party.GetPartyMember(1) != null)
                Slot1View = new CharacterBarView(_session.Party.GetPartyMember(1));
            if (_session.Party.GetPartyMember(2) != null)
                Slot2View = new CharacterBarView(_session.Party.GetPartyMember(2));
            if (_session.Party.GetPartyMember(3) != null)
                Slot3View = new CharacterBarView(_session.Party.GetPartyMember(3));
            if (_session.Party.GetPartyMember(4) != null)
                Slot4View = new CharacterBarView(_session.Party.GetPartyMember(4));
            if (_session.Party.GetPartyMember(5) != null)
                Slot5View = new CharacterBarView(_session.Party.GetPartyMember(5));
            if (_session.Party.GetPartyMember(6) != null)
                Slot6View = new CharacterBarView(_session.Party.GetPartyMember(6));
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
