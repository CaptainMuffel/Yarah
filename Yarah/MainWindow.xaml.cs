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

namespace Yarah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Rekenen(object sender, RoutedEventArgs e)
        {
            RekenenWindow rekenenWindow = new RekenenWindow();
            rekenenWindow.Show();
            this.Close(); // Close the current MainWindow
        }


        private void Button_Taal(object sender, RoutedEventArgs e)
        {
            ComingSoonWindow comingsoonWindow = new ComingSoonWindow();
            comingsoonWindow.Show();
            this.Close(); // Close the current MainWindow
        }

        private void Button_Aardrijkskunde(object sender, RoutedEventArgs e)
        {
            ComingSoonWindow comingsoonWindow = new ComingSoonWindow();
            comingsoonWindow.Show();
            this.Close(); // Close the current MainWindow
        }
        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            ComingSoonWindow comingsoonWindow = new ComingSoonWindow();
            comingsoonWindow.Show();
            this.Close(); // Close the current MainWindow
        }

        private void Button_Koekjes(object sender, RoutedEventArgs e)
        {
            ComingSoonWindow comingsoonWindow = new ComingSoonWindow();
            comingsoonWindow.Show();
            this.Close(); // Close the current MainWindow
        }
    }
}
