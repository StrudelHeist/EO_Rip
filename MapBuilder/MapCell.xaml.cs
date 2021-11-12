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

namespace MapBuilder
{
    /// <summary>
    /// Interaction logic for MapCell.xaml
    /// </summary>
    public partial class MapCell : UserControl, INotifyPropertyChanged
    {
        private MapCellType _cellType;

        public MapCellType CellType
        {
            get { return _cellType; }
            private set
            {
                _cellType = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CellType)));

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CellBackground)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CellTransparency)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageSource)));
            }
        }

        public string ImageSource
        {
            get
            {
                switch (CellType)
                {
                    case MapCellType.STAIR_UP:
                        return "pack://application:,,,/StairsUp.png";
                    case MapCellType.STAIR_DOWN:
                        return "pack://application:,,,/StairsDown.png";
                    case MapCellType.DOOR:
                        return "pack://application:,,,/Door.png";
                    case MapCellType.SHORTCUT:
                        return "pack://application:,,,/Shortcut.png";
                    default:
                        return string.Empty;
                }
            }
        }
        public Brush CellBackground
        {
            get
            {
                switch (_cellType)
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
                switch (_cellType)
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

        public MapCell()
        {
            DataContext = this;
            InitializeComponent();
        }

        public void SetCell(MapCellType cellType)
        {
            CellType = cellType;
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
