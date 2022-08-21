using System;
using System.Collections.Generic;
using System.IO;
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

namespace TSS.PresentationLayer.Wpf.Windows
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool maximized = true;

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMaximized_Click(object sender, RoutedEventArgs e)
        {
            if (maximized)
            {
                this.WindowState = WindowState.Normal;
                maximized = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                maximized = true;
            }
        }

        private void btnMinimized_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        BitmapImage logo = new BitmapImage();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStyle = WindowStyle.None;
            // pbMenu.Source = new Uri(Directory.GetCurrentDirectory() + "\\Images\\home.gif", UriKind.Relative);
            
        }
    }
}
