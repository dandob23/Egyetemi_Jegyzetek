using Microsoft.Win32;
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

namespace _1115
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb((byte)sliderR.Value, (byte)sliderG.Value, (byte)sliderB.Value);
            colorCanvas.Background = new SolidColorBrush(color);

        }
        Point prevPos;
        bool isMouseDown = false;
        private void mainCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isMouseDown = true;
                prevPos = e.GetPosition(mainCanvas);
            }
        }

        private void mainCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isMouseDown = false;
            }
        }

        private void mainCanvas_MouseMove(object sender, MouseButtonEventArgs e)
        {
            if (!isMouseDown)
            {
                return;
            }
            Point pos = e.GetPosition(mainCanvas);
            Line line = new Line();
            line.X1 = pos.X;
            line.Y1 = pos.Y;
            line.X2 = prevPos.X;
            line.Y2 = prevPos.Y;
            line.Stroke = colorCanvas.Background;
            mainCanvas.Children.Add(line);
            prevPos = pos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.jpg;*.bmp;*.png;|All files|*.*";

            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }
            ImageSource image = new BitmapImage(new Uri(openFileDialog.FileName));
            this.image.Source = image;
            label.Content = openFileDialog.FileName;
        
        }

        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
