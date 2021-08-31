using System;
using System.Windows;
using System.Windows.Controls;

namespace EtrianOdysseyWpf.View
{
    /// <summary>
    /// Interaction logic for TownView.xaml
    /// </summary>
    public partial class TownView : UserControl
    {
        public event EventHandler<AvailableViews> NewViewRequested;

        public TownView()
        {
            InitializeComponent();
        }

        private void GuildClicked(object sender, RoutedEventArgs e)
        {
            NewViewRequested?.Invoke(this, AvailableViews.GUILD_HOUSE);
        }
    }
}
