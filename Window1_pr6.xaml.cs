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
using Pr5_6;

namespace pr5_6
{
    /// <summary>
    /// Логика взаимодействия для Window1_pr6.xaml
    /// </summary>
    public partial class Window1_pr6 : Window
    {
        public Window1_pr6()
        {
            InitializeComponent();
        }

        private void OpenTextEditor_Click(object sender, RoutedEventArgs e)
        {
            var textEditorWindow = new TextEditorWindow();
            textEditorWindow.Show();
        }
    }
}
