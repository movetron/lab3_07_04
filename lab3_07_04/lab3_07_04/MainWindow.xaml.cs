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

namespace lab3_07_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brush _brush = Brushes.Black;
        private double _size = 5;
        private bool _isDrawing = false;
        private Point _lastPoint;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InkCanvas inkCanvas1 = new InkCanvas();
            var inkCanvas = inkCanvas1;
            var colorString = colorComboBox.SelectedValue as string;
            if (!string.IsNullOrEmpty(colorString))
            {
                var color = ColorConverter.ConvertFromString(colorString) as Color?;
                if (color.HasValue)
                {
                    _brush = new SolidColorBrush(color.Value);
                    inkCanvas.DefaultDrawingAttributes.Color = color.Value;
                }
            }
        }

    }
}
