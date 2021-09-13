using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace MapBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private const int MAP_WIDTH = 30;
        private const int MAP_HEIGHT = 30;

        private ObservableCollection<MapCell> _mapCells;
        private MapCellType _operationMode;
        private string _saveFileName;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DoorButtonBack)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShortcutButtonBack)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EraseButtonBack)));
            }
        }

        public string SaveFileName
        {
            get { return _saveFileName; }
            set
            {
                _saveFileName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SaveFileName)));
            }
        }

        public Brush FloorButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.FLOOR)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }
        public Brush WallButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.WALL)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }
        public Brush StairUpButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.STAIR_UP)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }
        public Brush StairDownButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.STAIR_DOWN)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }
        public Brush DoorButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.DOOR)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }
        public Brush ShortcutButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.SHORTCUT)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }
        public Brush EraseButtonBack
        {
            get
            {
                if (OperationMode == MapCellType.DEFAULT)
                    return Brushes.Green;
                else
                    return Brushes.LightGray;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            OperationMode = MapCellType.FLOOR;
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
        private void DoorButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.DOOR;
        }
        private void ShortcutButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.SHORTCUT;
        }
        private void EraseButtonClicked(object sender, RoutedEventArgs e)
        {
            OperationMode = MapCellType.DEFAULT;
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            int total = MAP_HEIGHT * MAP_WIDTH;

            using (StreamWriter outfile = new StreamWriter(SaveFileName))
            {
                for (int i = 0; i < total; i++) {
                    if ((i + 1) % MAP_WIDTH == 0)
                        outfile.WriteLine(GetMapCharacter(MapCells[i]));
                    else
                        outfile.Write(GetMapCharacter(MapCells[i]));
                }
            }

        }
        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (MapCell cell in MapCells)
                cell.SetCell(MapCellType.DEFAULT);
        }

        private string GetMapCharacter(MapCell cell)
        {
            switch (cell.CellType)
            {
                case MapCellType.FLOOR:
                    return "O";
                case MapCellType.DOOR:
                    return "D";
                case MapCellType.SHORTCUT:
                    return "S";
                case MapCellType.STAIR_DOWN:
                    return "<";
                case MapCellType.STAIR_UP:
                    return ">";
                default:
                    return "X";
            }
        }
    }
}
