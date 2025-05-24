using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Media;

namespace Window1_Pr4
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private DrawingAttributes _selectedDrawingAttribute;
        private InkCanvasEditingMode _editingMode;

        public DrawingAttributes[] DrawingAttributesList { get; } =
        {
            new DrawingAttributes { Color = Colors.Red, Width = 3, Height = 3 },
            new DrawingAttributes { Color = Colors.Green, Width = 10, Height = 10 },
            new DrawingAttributes { Color = Colors.Blue, Width = 15, Height = 15 }
        };

        public InkCanvasEditingMode[] EditingModes { get; } =
        {
            InkCanvasEditingMode.Ink,
            InkCanvasEditingMode.Select,
            InkCanvasEditingMode.EraseByPoint
        };

        public DrawingAttributes SelectedDrawingAttribute
        {
            get => _selectedDrawingAttribute;
            set
            {
                _selectedDrawingAttribute = value;
                OnPropertyChanged();
            }
        }

        public InkCanvasEditingMode EditingMode
        {
            get => _editingMode;
            set
            {
                _editingMode = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            SelectedDrawingAttribute = DrawingAttributesList[0];
            EditingMode = EditingModes[0];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
