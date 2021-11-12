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
    public partial class DungeonView : UserControl, INotifyPropertyChanged
    {
        private const int MAP_WIDTH = 30;
        private const int MAP_HEIGHT = 30;

        private ObservableCollection<MapCell> _mapCells;

        public ObservableCollection<MapCell> MapCells
        {
            get { return _mapCells; }
            set
            {
                _mapCells = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MapCells)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public DungeonView()
        {
            MapCells = new ObservableCollection<MapCell>();
            int total = MAP_WIDTH * MAP_HEIGHT;
            for (int i = 0; i < total; i++)
            {
                var cell = new MapCell();
                cell.CellClicked += MapCellClicked;
                MapCells.Add(cell);
            }

            DataContext = this;
            InitializeComponent();
        }


        private void MapCellClicked(object sender, EventArgs e)
        {
            var mapCell = sender as MapCell;
        }
    }
}
