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
using Waterskibaan_WPF__new_.Klassen;

namespace Waterskibaan_WPF__new_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game _game;

        public MainWindow()
        {
            _game = new Game();

            _game.Initialize();
            _game.NieuweBezoeker += fillStatus;

            InitializeComponent();
            createSquareGrid(BaseGrid);
        }

        public void createSquareGrid(Grid baseGrid)
        {
            BaseGrid.Background = new SolidColorBrush(Colors.DarkGreen);

            int rowCount = baseGrid.RowDefinitions.Count;
            int columnCount = baseGrid.ColumnDefinitions.Count;

            for (int j = 0; j <= rowCount; j++)
            {
                for (int i = 0; i <= columnCount; i++)
                {
                    var gridRect = new Grid()
                    {
                        Background = new SolidColorBrush(Colors.Green),
                        Margin = new Thickness(1)
                    };

                    Grid.SetColumn(gridRect, i);
                    Grid.SetRow(gridRect, j);
                    baseGrid.Children.Add(gridRect);
                }
            }
        }

        public void fillStatus(NieuweBezoekerArgs args)
        {
            this.Dispatcher.Invoke(() =>
            {
                StatusTextBlock.Text = _game.wb.ToString();
            });
        }
    }
}
