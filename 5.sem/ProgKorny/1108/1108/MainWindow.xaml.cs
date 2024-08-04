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

namespace _1108
{
    //crud muvelet kell  beadandoban, de adatbazis nem
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Megnyomtad a gombot!");
            //MyButton.Content = "OK";
        
            SecondWindow sw = new SecondWindow();
            sw.ShowDialog();
            if (sw.checkBox.IsChecked == null || sw.checkBox.IsChecked == false)
            {
                label1.Content = "Unchecked";
            }
            else
            {
                label1.Content = "Checked";
            }
            label2.Content = sw.ComboBox.SelectedItem.ToString();
            label3.Content = sw.Slider.Value.ToString();
            label4.Content = sw.TextBox.Text;
            label5.Content = sw.getRadioButtonContent();
        }
    }
}
