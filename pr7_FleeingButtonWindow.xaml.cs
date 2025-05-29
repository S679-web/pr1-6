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
    /// Логика взаимодействия для FleeingButtonWindow.xaml
    /// </summary>
    public partial class FleeingButtonWindow : Window
    {
        private const double MoveDistance = 90; //расстояние
        public FleeingButtonWindow()
        {
            InitializeComponent();
        }

        private void FleeingButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (FleeingButton != null)
            {
                double currentLeft = Canvas.GetLeft(FleeingButton);
                double currentTop = Canvas.GetTop(FleeingButton);

                double newLeft = currentLeft + GetRandomOffset(MoveDistance);
                double newTop = currentTop + GetRandomOffset(MoveDistance);

                newLeft = Math.Max(0, Math.Min(newLeft, MainCanvas.ActualWidth - FleeingButton.ActualWidth));
                newTop = Math.Max(0, Math.Min(newTop, MainCanvas.ActualHeight - FleeingButton.ActualHeight));

                Canvas.SetLeft(FleeingButton, newLeft);
                Canvas.SetTop(FleeingButton, newTop);
            }
        }

        private double GetRandomOffset(double range)
        {
            Random rand = new Random();
            return rand.NextDouble() * range * 2 - range;
        }
    }
}
