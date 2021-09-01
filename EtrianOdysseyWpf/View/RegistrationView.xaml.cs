using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EtrianOdysseyWpf.View
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// --> This view is for adding characters to our party
    /// </summary>
    public partial class RegistrationView : UserControl, INotifyPropertyChanged
    {
        private string _classTitle;
        private string _classSubtitle;
        private string _classDescription;

        public event PropertyChangedEventHandler PropertyChanged;

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
            DataContext = this;
            InitializeComponent();
        }

        private void OnMouseEnterBrian(object sender, MouseEventArgs e)
        {
            ClassTitle = "Hero";
            ClassSubtitle = "Frontline offense/defense";
            ClassDescription = "Determined warrior of the sword and shield. He not only aides the party, but delivers raging blows seemingly beyond a normal person's capabilites.";
        }

        private void OnMouseEnterBraven(object sender, MouseEventArgs e)
        {
            ClassTitle = "Imperial";
            ClassSubtitle = "Frontline offense+";
            ClassDescription = "Loyal knight who uses a unique drive blade. Attacks with it can be devestating, but place a heavy burden on its inner workings.";
        }
        private void OnMouseEnterJacob(object sender, MouseEventArgs e)
        {
            ClassTitle = "Medic";
            ClassSubtitle = "Backline healer";
            ClassDescription = "Healer who treats the party's wounds. His combat skill is limited, but he is highly useful regardless";
        }
        private void OnMouseEnterJustin(object sender, MouseEventArgs e)
        {
            ClassTitle = "Protector";
            ClassSubtitle = "Frontline defender+";
            ClassDescription = "Holy knight sworn to guard others with his life. His sheild is an invaluable tool for surviving the labyrinth";
        }
        private void OnMouseEnterGabe(object sender, MouseEventArgs e)
        {
            ClassTitle = "Harbinger";
            ClassSubtitle = "Flex ailment specialist";
            ClassDescription = "Manipulator of miasma. He weakens foes with it, then uses his weapon to cut them down.";
        }
    }
}
