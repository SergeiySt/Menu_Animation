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

        private void buttonHelp_Click(object sender, RoutedEventArgs e)
        {
            WPFHelp wPFHelp = new WPFHelp();

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = TimeSpan.FromMilliseconds(500);

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTarget(animation, wPFHelp);
            Storyboard.SetTargetProperty(animation, new PropertyPath(UIElement.OpacityProperty));

            wPFHelp.Opacity = 0;
            wPFHelp.Show();

            storyboard.Begin();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
