using System;
using System.Collections.Generic;
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
    /// Interaction logic for ExplorersGuild.xaml
    /// </summary>
    public partial class ExplorersGuild : UserControl
    {
        public event EventHandler<AvailableViews> NewViewRequested;

        public ExplorersGuild()
        {
            InitializeComponent();
        }

        private void RegisterClicked(object sender, RoutedEventArgs e)
        {
            NewViewRequested?.Invoke(this, AvailableViews.HERO_REGISTRATION);
        }

        private void LeaveClicked(object sender, RoutedEventArgs e)
        {
            NewViewRequested?.Invoke(this, AvailableViews.TOWN_SQUARE);
        }
    }
}
