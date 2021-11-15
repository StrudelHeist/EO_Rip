using EtrianOdysseyShared;
using EtrianOdysseyShared.Maps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for DungeonView.xaml
    /// </summary>
    public partial class DungeonView : UserControl, IGameView
    {
        // Viewport should be a 5x5 viewing area of the current map
        private ObservableCollection<MapCell> _viewPort;

        public ObservableCollection<MapCell> ViewPort
        {
            get { return _viewPort; }
            set
            {
                _viewPort = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ViewPort)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<TransitionMessage> NewViewRequested;

        public DungeonView()
        {
            DataContext = this;
            InitializeComponent();
        }


        private void MapCellClicked(object sender, EventArgs e)
        {
            var mapCell = sender as MapCell;
        }

        public void Setup(GameSession session)
        {
            // Setup map 
            DungeonMap map = session.CurrentMap;

            ViewPort = new ObservableCollection<MapCell>();
            for (int i = 0; i < 25; i++)
            {
                var cell = new MapCell(map.MapCells[i]);
                cell.CellClicked += MapCellClicked;
                ViewPort.Add(cell);
            }


        }
    }
}
