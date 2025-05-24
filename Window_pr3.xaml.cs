using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace pr1_6
{
    public partial class Window_pr3 : Window
    {
        public Window_pr3()
        {
            InitializeComponent();
        }

        private void ChangeBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Кожевников Сергей\nВерсия: 3.0", "О программе");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Обработчики для строки состояния
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Вы выбрали " + ((MenuItem)sender).Header;
        }

        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "";
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "Вы навели на кнопку " + ((Button)sender).ToolTip;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            statusBarText.Text = "";
        }
    }
}