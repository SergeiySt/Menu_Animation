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

namespace Animation_menu
{
    /// <summary>
    /// Interaction logic for WPFHelp.xaml
    /// </summary>
    public partial class WPFHelp : Window
    {
        public WPFHelp()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //media.Position = TimeSpan.Zero;
            //media.Play();
            //media.MediaEnded += Media_MediaEnded;
        }

        private void Media_MediaEnded(object sender, RoutedEventArgs e)
        {
            //media.Position = TimeSpan.Zero;
            //media.Play();
        }
    }
}
