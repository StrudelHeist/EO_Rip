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
        private CityGatesView _cityGatesView;
        private DungeonView _dungeonView;

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
            _cityGatesView = new CityGatesView();
            _dungeonView = new DungeonView();

            _townView.NewViewRequested += OnNewViewRequested;
            _explorersGuildView.NewViewRequested += OnNewViewRequested;
            _registrationView.NewViewRequested += OnNewViewRequested;
            _cityGatesView.NewViewRequested += OnNewViewRequested;

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
                case AvailableViews.CITY_GATE:
                    CurrentContent = _cityGatesView;
                    break;
                case AvailableViews.DUNGEON:
                    CurrentContent = _dungeonView;
                    break;
            }

            (CurrentContent as IGameView).Setup(message.SessionInformation);
        }
    }
}
