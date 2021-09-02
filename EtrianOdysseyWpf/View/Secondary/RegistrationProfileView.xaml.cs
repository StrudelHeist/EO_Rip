using EtrianOdysseyShared;
using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EtrianOdysseyWpf.View.Secondary
{
    /// <summary>
    /// Interaction logic for RegistrationProfileView.xaml
    /// </summary>
    public partial class RegistrationProfileView : UserControl, INotifyPropertyChanged
    {
        private Brush _borderColor;
        private PartyMember _character;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<PartyMember> CharacterClicked;
        public event EventHandler<PartyMember> CharacterMouseEnter;
        public event EventHandler<PartyMember> CharacterMouseLeave;

        public string CharacterName
        {
            get
            {
                return _character.Name;
            }
        }
        public string ImagePath
        {
            get
            {
                return _character.ImagePath;
            }
        }
        public Brush BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BorderColor)));
            }
        }

        public RegistrationProfileView(PartyMember character)
        {
            _character = character;

            DataContext = this;
            InitializeComponent();
        }

        private void CharacterNameClick(object sender, System.Windows.RoutedEventArgs e)
        {
            CharacterClicked?.Invoke(this, _character);
        }
        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            CharacterMouseEnter?.Invoke(this, _character);
        }
        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            CharacterMouseLeave?.Invoke(this, _character);
        }
    }
}
