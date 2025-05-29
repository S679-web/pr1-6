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

namespace pr7_9
{
    /// <summary>
    /// Логика взаимодействия для Window_pr10.xaml
    /// </summary>
    public partial class Window_pr10 : Window
    {
        public Window_pr10()
        {
            InitializeComponent();
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            var switchesWindow = new SwitchesWindow();
            switchesWindow.Show();
        }
    }
}
