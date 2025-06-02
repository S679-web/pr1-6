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

namespace pr12_UP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenImageGallery_Click(object sender, RoutedEventArgs e)
        {
            var galleryWindow = new ImageGalleryWindow();
            galleryWindow.Show();
        }
        private void OpenRoadSigns_Click(object sender, RoutedEventArgs e)
        {
            var roadWindow = new RoadSignsWindow();
            roadWindow.Show();
        }
    }
}
