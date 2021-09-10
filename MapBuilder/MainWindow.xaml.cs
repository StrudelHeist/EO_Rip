using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace MapBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<MapCell> _mapCells;
        private MapCellType _operationMode;


        public ObservableCollection<MapCell> MapCells
        {
            get { return _mapCells; }
            set
            {
                _mapCells = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MapCells)));
            }
        }

        public MapCellType OperationMode
        {
            get { return _operationMode; }
            set
            {
                _operationMode = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OperationMode)));

                // Update button colors so we know our current operation type
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FloorButtonBack)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WallButtonBack)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StairUpButtonBack)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StairDownButtonBack)));
            }
        }

        public Brush FloorButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.FLOOR)
                    return Brushes.Green;
                else
                    return Brushes.Gray;
            }
        }
        public Brush WallButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.WALL)
                    return Brushes.Green;
                else
                    return Brushes.Gray;
            }
        }
        public Brush StairUpButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.STAIR_UP)
                    return Brushes.Green;
                else
                    return Brushes.Gray;
            }
        }
        public Brush StairDownButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.STAIR_DOWN)
                    return Brushes.Green;
                else
                    return Brushes.Gray;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public MainWindow()
        {
            OperationMode = MapCellType.FLOOR;
            MapCells = new ObservableCollection<MapCell>();
            for (int i = 0; i < 900; i++)
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
            (sender as MapCell).SetCell(OperationMode);
        }

        private void FloorButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.FLOOR;
        }
        private void WallButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.WALL;
        }
        private void StairUpButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.STAIR_UP;
        }
        private void StairDownButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.STAIR_DOWN;
        }
    }
}
