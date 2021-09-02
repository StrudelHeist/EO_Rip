using EtrianOdysseyShared;
using EtrianOdysseyShared.Characters;
using EtrianOdysseyWpf.View.Secondary;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EtrianOdysseyWpf.View
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// --> This view is for adding characters to our party
    /// </summary>
    public partial class RegistrationView : UserControl, INotifyPropertyChanged
    {
        private enum Mode
        {
            SELECT_CHARACTER,
            CHOOSE_SLOT
        }

        private Mode _operationMode;
        private PartyMember _lastSelectedPartyMember;
        private ObservableCollection<RegistrationProfileView> _characterViews;

        private string _classTitle;
        private string _classSubtitle;
        private string _classDescription;

        private string _slot1Name;
        private string _slot2Name;
        private string _slot3Name;
        private string _slot4Name;
        private string _slot5Name;
        private string _slot6Name;

        private Brush _slotButtonColor;

        public event PropertyChangedEventHandler PropertyChanged;

        private Mode OperationMode
        {
            get
            {
                return _operationMode;
            }
            set
            {
                _operationMode = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OperationMode)));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SlotButtonColor)));
            }
        }
        public ObservableCollection<RegistrationProfileView> CharacterViews
        {
            get
            {
                return _characterViews;
            }
            set
            {
                _characterViews = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CharacterViews)));
            }
        }
        public Brush SlotButtonColor
        {
            get
            {
                if (OperationMode == Mode.CHOOSE_SLOT)
                    return Brushes.LightGreen;
                else
                    return Brushes.Gray;
            }
        }
        public string Slot1Name
        {
            get
            {
                return _slot1Name;
            }
            set
            {
                _slot1Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot1Name)));
            }
        }
        public string Slot2Name
        {
            get
            {
                return _slot2Name;
            }
            set
            {
                _slot2Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot2Name)));
            }
        }
        public string Slot3Name
        {
            get
            {
                return _slot3Name;
            }
            set
            {
                _slot3Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot3Name)));
            }
        }
        public string Slot4Name
        {
            get
            {
                return _slot4Name;
            }
            set
            {
                _slot4Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot4Name)));
            }
        }
        public string Slot5Name
        {
            get
            {
                return _slot5Name;
            }
            set
            {
                _slot5Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot5Name)));
            }
        }
        public string Slot6Name
        {
            get
            {
                return _slot6Name;
            }
            set
            {
                _slot6Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slot6Name)));
            }
        }
        public string ClassTitle
        {
            get { return _classTitle; }
            set
            {
                _classTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ClassTitle)));
            }
        }
        public string ClassSubtitle
        {
            get { return _classSubtitle; }
            set
            {
                _classSubtitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ClassSubtitle)));
            }
        }
        public string ClassDescription
        {
            get { return _classDescription; }
            set
            {
                _classDescription = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ClassDescription)));
            }
        }

        public RegistrationView()
        {
            Slot1Name = "--EMPTY--";
            Slot2Name = "--EMPTY--";
            Slot3Name = "--EMPTY--";
            Slot4Name = "--EMPTY--";
            Slot5Name = "--EMPTY--";
            Slot6Name = "--EMPTY--";

            // Build out party selection
            CharacterViews = new ObservableCollection<RegistrationProfileView>();
            CharacterViews.Add(new RegistrationProfileView(new Braven()));
            CharacterViews.Add(new RegistrationProfileView(new Brian()));
            CharacterViews.Add(new RegistrationProfileView(new Justin()));
            CharacterViews.Add(new RegistrationProfileView(new Gabe()));
            CharacterViews.Add(new RegistrationProfileView(new Jacob()));

            foreach (var profileView in CharacterViews)
            {
                profileView.CharacterClicked += ProfileView_CharacterClicked;
                profileView.CharacterMouseEnter += ProfileView_CharacterMouseEnter;
                profileView.CharacterMouseLeave += ProfileView_CharacterMouseLeave;
            }

            DataContext = this;
            InitializeComponent();
        }

        private void ProfileView_CharacterMouseLeave(object sender, EtrianOdysseyShared.PartyMember e)
        {
            if (OperationMode == Mode.CHOOSE_SLOT)
                return;

            DefaultAllBorders();
            ClearHeadings();
        }
        private void ProfileView_CharacterMouseEnter(object sender, EtrianOdysseyShared.PartyMember e)
        {
            if (OperationMode == Mode.CHOOSE_SLOT)
                return;

            DefaultAllBorders();

            (sender as RegistrationProfileView).BorderColor = new SolidColorBrush(Color.FromRgb(0x00, 0x00, 0xFF));

            ClassTitle = e.Job.JobTitle;
            ClassSubtitle = e.Job.JobSubtitle;
            ClassDescription = e.Job.JobDescription;
        }
        private void ProfileView_CharacterClicked(object sender, EtrianOdysseyShared.PartyMember e)
        {
            ClearHeadings();
            ClassSubtitle = $"Please choose a party position for {e.Name}";
            _lastSelectedPartyMember = e;
            OperationMode = Mode.CHOOSE_SLOT;
        }

        private void DefaultAllBorders()
        {
            foreach (var profileView in CharacterViews)
                profileView.BorderColor = new SolidColorBrush(Color.FromRgb(0xFF, 0xFF, 0xFF));
        }
        private void ClearHeadings()
        {
            ClassTitle = string.Empty;
            ClassSubtitle = string.Empty;
            ClassDescription = string.Empty;
        }

        private void SlotClicked(object sender, RoutedEventArgs e)
        {
            // TODO: Put last selected party member here
        }
    }
}
