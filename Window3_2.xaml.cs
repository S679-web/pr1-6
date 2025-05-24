using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Pr3_2
{
    public partial class MainWindow : Window
    {
        private bool isDrawing = false;
        private Point lastPoint;

        public IInputElement DrawingCanvas { get; private set; }
        public object DrawMode { get; private set; }
        public object DeleteMode { get; private set; }
        public object BrushSizeSlider { get; private set; }
        public object ColorComboBox { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawingCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (DrawMode.IsChecked == true)
            {
                isDrawing = true;
                lastPoint = e.GetPosition(DrawingCanvas);
            }
            else if (DeleteMode.IsChecked == true)
            {
                // Удалить фигуры по клику
                var pos = e.GetPosition(DrawingCanvas);
                foreach (var child in DrawingCanvas.Children)
                {
                    if (child is Shape shape) // Изменено: используем Shape, а не Ellipse
                    {
                        // Более надежный способ получения центра фигуры
                        double centerX = Canvas.GetLeft(shape) + shape.Width / 2;
                        double centerY = Canvas.GetTop(shape) + shape.Height / 2;
                        var center = new Point(centerX, centerY);

                        if ((pos - center).Length < 10)
                        {
                            DrawingCanvas.Children.Remove(shape);
                            break;
                        }
                    }
                }
            }
        }

        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && DrawMode.IsChecked == true)
            {
                Point currentPoint = e.GetPosition(DrawingCanvas);
                DrawLine(lastPoint, currentPoint);
                lastPoint = currentPoint;
            }
        }

        private void DrawingCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }

        private void DrawLine(Point from, Point to)
        {
            Line line = new Line
            {
                X1 = from.X,
                Y1 = from.Y,
                X2 = to.X,
                Y2 = to.Y,
                Stroke = GetSelectedBrush(),
                StrokeThickness = BrushSizeSlider.Value
            };

            DrawingCanvas.Children.Add(line);
        }

        private Brush GetSelectedBrush()
        {
            if (ColorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string colorName = selectedItem.Tag.ToString();
                var property = typeof(Brushes).GetProperty(colorName);
                if (property != null)
                {
                    return property.GetValue(null) as Brush;
                }
            }
            return Brushes.Black;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Нечего делать, код весь в GetSelectedBrush
        }
    }
}