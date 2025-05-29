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
using System.Windows.Media.Animation;

namespace Pr7_9
{
    /// <summary>
    /// Логика взаимодействия для PulsarWindow.xaml
    /// </summary>
    public partial class PulsarWindow : Window
    {
        public PulsarWindow()
        {
            InitializeComponent();
            StartPulsingAnimation();
        }

        private void StartPulsingAnimation()
        {
            var innerStop = PulsarGradient.GradientStops[0];
            var middleStop = PulsarGradient.GradientStops[1];
            var outerStop = PulsarGradient.GradientStops[2];

            var innerColorAnimation = new ColorAnimationUsingKeyFrames
            {
                Duration = TimeSpan.FromSeconds(4),
                RepeatBehavior = RepeatBehavior.Forever
            };
            innerColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));
            innerColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Red, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            innerColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Red, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2))));
            innerColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3))));
            innerColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4))));

            var middleColorAnimation = new ColorAnimationUsingKeyFrames
            {
                Duration = TimeSpan.FromSeconds(4),
                RepeatBehavior = RepeatBehavior.Forever
            };

            middleColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Color.FromRgb(0xFF, 0xDD, 0x00), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));
            middleColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Color.FromRgb(0xFF, 0x44, 0x00), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1))));
            middleColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Color.FromRgb(0xFF, 0x00, 0x00), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2))));
            middleColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Color.FromRgb(0xFF, 0x44, 0x00), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(3))));
            middleColorAnimation.KeyFrames.Add(new LinearColorKeyFrame(Color.FromRgb(0xFF, 0xDD, 0x00), KeyTime.FromTimeSpan(TimeSpan.FromSeconds(4))));


            innerStop.BeginAnimation(GradientStop.ColorProperty, innerColorAnimation);
            middleStop.BeginAnimation(GradientStop.ColorProperty, middleColorAnimation);
        }
    }
}
