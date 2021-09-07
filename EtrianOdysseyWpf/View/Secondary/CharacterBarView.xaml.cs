using EtrianOdysseyShared;
using System.ComponentModel;
using System.Windows.Controls;

namespace EtrianOdysseyWpf.View.Secondary
{
    /// <summary>
    /// Interaction logic for CharacterBarView.xaml
    /// </summary>
    public partial class CharacterBarView : UserControl, INotifyPropertyChanged
    {
        private PartyMember _character;

        public PartyMember Character
        {
            get
            {
                return _character;
            }
            set
            {
                _character = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Character)));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Level)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CharacterName)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HealthPoints)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TP)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HPBarMax)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentHP)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TPBarMax)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTP)));
            }
        }

        public string Level
        {
            get
            {
                if (_character == null)
                    return "??";
                else
                    return _character.Level.ToString();
            }
        }
        public string CharacterName
        {
            get
            {
                if (_character == null)
                    return "??";
                else
                    return _character.Name;
            }
        }
        public string HealthPoints
        {
            get
            {
                if (_character == null)
                    return "??";
                else
                    return _character.ActualHP.ToString();
            }
        }
        public string TP
        {
            get
            {
                if (_character == null)
                    return "??";
                else
                    return _character.ActualTP.ToString();
            }
        }
        public int HPBarMax
        {
            get
            {
                if (_character == null)
                    return 100;
                else
                    return _character.BaseHP;
            }
        }
        public int CurrentHP
        {
            get
            {
                if (_character == null)
                    return 100;
                else
                    return _character.ActualHP;
            }
        }
        public int TPBarMax
        {
            get
            {
                if (_character == null)
                    return 100;
                else
                    return _character.BaseTP;
            }
        }
        public int CurrentTP
        {
            get
            {
                if (_character == null)
                    return 100;
                else
                    return _character.ActualTP;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CharacterBarView(PartyMember character)
        {
            Character = character;

            DataContext = this;
            InitializeComponent();
        }

    }
}
