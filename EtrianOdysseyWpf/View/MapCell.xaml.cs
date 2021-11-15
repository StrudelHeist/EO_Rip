using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using EtrianOdysseyShared.Maps;

namespace EtrianOdysseyWpf.View
{
    /// <summary>
    /// Interaction logic for MapCell.xaml
    /// </summary>
    public partial class MapCell : UserControl, INotifyPropertyChanged
    {
        private DungeonMapCell _cell;

        public DungeonMapCell Cell {
            get
            {
                return _cell;
            }
            private set
            {
                _cell = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cell)));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CellBackground)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CellTransparency)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageSource)));
            }
        }
        public string ImageSource
        {
            get
            {
                switch (Cell.CellType)
                {
                    case MapCellType.STAIR_UP:
                        return "pack://application:,,,/Images/MapIcons/StairsUp.png";
                    case MapCellType.STAIR_DOWN:
                        return "pack://application:,,,/Images/MapIcons/StairsDown.png";
                    case MapCellType.DOOR:
                        return "pack://application:,,,/Images/MapIcons/Door.png";
                    case MapCellType.SHORTCUT:
                        return "pack://application:,,,/Images/MapIcons/Shortcut.png";
                    default:
                        return string.Empty;
                }
            }
        }
        public Brush CellBackground
        {
            get
            {
                switch (Cell.CellType)
                {
                    case MapCellType.FLOOR:
                        return Brushes.Green;
                    case MapCellType.WALL:
                        return Brushes.Brown;
                    default:
                        return Brushes.Green;
                }
            }
        }
        public double CellTransparency
        {
            get
            {
                switch (Cell.CellType)
                {
                    case MapCellType.FLOOR:
                        return 1;
                    case MapCellType.WALL:
                        return 1;
                    default:
                        return 0.3;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CellClicked;

        public MapCell(DungeonMapCell mapCell)
        {
            Cell = mapCell;
            DataContext = this;
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CellClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                CellClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
