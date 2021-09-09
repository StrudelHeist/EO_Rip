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

namespace MapBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private enum MapDrawType
        {
            FLOOR,
            WALL,
            DOOR,
            SHORTCUT,
            STAIR_UP,
            STAIR_DOWN,
            WARP_POINT
        }

        private ObservableCollection<MapCell> _mapCells;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MapCell> MapCells
        {
            get { return _mapCells; }
            set
            {
                _mapCells = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MapCells)));
            }
        }

        public MainWindow()
        {
            MapCells = new ObservableCollection<MapCell>();
            for (int i = 0; i < 10; i++)
                MapCells.Add(new MapCell());

            DataContext = this;
            InitializeComponent();
        }

    }
}
