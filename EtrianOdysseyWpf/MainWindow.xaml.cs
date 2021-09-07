using EtrianOdysseyWpf.View;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace EtrianOdysseyWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private UserControl _currentContent;

        private TownView _townView;
        private RegistrationView _registrationView;
        private ExplorersGuild _explorersGuildView;

        public event PropertyChangedEventHandler PropertyChanged;

        public UserControl CurrentContent
        {
            get
            {
                return _currentContent;
            }
            set
            {
                _currentContent = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentContent)));
            }
        }

        public MainWindow()
        {
            _townView = new TownView();
            _registrationView = new RegistrationView();
            _explorersGuildView = new ExplorersGuild();

            _townView.NewViewRequested += OnNewViewRequested;
            _explorersGuildView.NewViewRequested += OnNewViewRequested;
            _registrationView.NewViewRequested += OnNewViewRequested;

            _townView.Setup(new EtrianOdysseyShared.GameSession());
            CurrentContent = _townView;

            DataContext = this;
            InitializeComponent();
        }

        private void OnNewViewRequested(object sender, TransitionMessage message)
        {
            switch (message.RequestedView)
            {
                case AvailableViews.GUILD_HOUSE:
                    CurrentContent = _explorersGuildView;
                    break;
                case AvailableViews.HERO_REGISTRATION:
                    CurrentContent = _registrationView;
                    break;
                case AvailableViews.TOWN_SQUARE:
                    CurrentContent = _townView;
                    break;
            }

            (CurrentContent as IGameView).Setup(message.SessionInformation);
        }
    }
}
