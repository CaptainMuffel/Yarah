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
using System.Windows.Shapes;

namespace Yarah
{
    /// <summary>
    /// Interaction logic for RekenenWindow.xaml
    /// </summary>
    public partial class RekenenWindow : Window
    {
        public RekenenWindow()
        {
            InitializeComponent();
        }
        private void Button_Optellen(object sender, RoutedEventArgs e)
        {
            OptellenWindow optellenWindow = new OptellenWindow();
            optellenWindow.Show();
            this.Close(); // Close the current RekenenWindow
        }
        private void Button_Aftrekken(object sender, RoutedEventArgs e)
        {
            AftrekkenWindow aftrekkenWindow = new AftrekkenWindow();
            aftrekkenWindow.Show();
            this.Close(); // Close the current RekenenWindow
        }
        private void Button_Hoofdmenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Close the current RekenenWindow
        }

        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            ComingSoonWindow comingsoonWindow = new ComingSoonWindow();
            comingsoonWindow.Show();
            this.Close(); // Close the current RekenenWindow
        }

        private void Button_Koekjes(object sender, RoutedEventArgs e)
        {
            ComingSoonWindow comingsoonWindow = new ComingSoonWindow();
            comingsoonWindow.Show();
            this.Close(); // Close the current RekenenWindow
        }
    }
}
