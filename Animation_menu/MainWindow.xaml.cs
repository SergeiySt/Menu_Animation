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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation_menu
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

    
        private void ToggleMenu(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = MenuPanel.ActualWidth;
            animation.To = MenuPanel.ActualWidth == 0 ? 200 : 0;
            animation.Duration = TimeSpan.FromSeconds(0.5);
            MenuPanel.BeginAnimation(Border.WidthProperty, animation);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
            //window1.Show();
            //Button button = (Button)sender;
            //button.Style = (Style)button.FindResource(typeof(Button));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Button button = (Button)sender;
            //button.Style = (Style)button.FindResource(typeof(Button));
            
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Heloo!!!!", "111", MessageBoxButton.OK);
        //}
    }
}
