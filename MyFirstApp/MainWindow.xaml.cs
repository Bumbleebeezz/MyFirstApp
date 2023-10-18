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

namespace MyFirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            UsernameLabel.Text = Counter.ToString();

            var newGrid = new Grid();

            for (int i = 0; i < 10; i++)
            {
                var row = new RowDefinition();
                newGrid.RowDefinitions.Add(row);
            }
            for (int i = 0; i < 10; i++)
            {
                var col = new ColumnDefinition();
                newGrid.ColumnDefinitions.Add(col);
            }

            var myButton = new Button();
            newGrid.Children.Add(myButton);
            MyGrid.Children.Add(newGrid);
        }

        private void Button_PlusOne(object sender, RoutedEventArgs e)
        {
            Counter++;
            UsernameLabel.Text = Counter.ToString();
            //TextBlock myText = new TextBlock();
            //myText.Text = "BUH!";
            //MyPanel.Children.Add(myText);

        }

        private void Button_MinusOne(object sender, RoutedEventArgs e)
        {
            Counter--;
            UsernameLabel.Text = Counter.ToString();
        }
    }
}
