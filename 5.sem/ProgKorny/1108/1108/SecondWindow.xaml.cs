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

namespace _1108
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
            radioButtons.Add(rb1);
            radioButtons.Add(rb2);
            radioButtons.Add(rb3);
            ComboBox.Items.Add("a");
            ComboBox.Items.Add("b");
            ComboBox.Items.Add("c");
            ComboBox.Items.Add("d");
            ComboBox.SelectedIndex = 0;
        }
        List<RadioButton> radioButtons = new List<RadioButton>();

        public string getRadioButtonContent()
        {
            foreach (RadioButton radiobutton in radioButtons)
            {
                if (radiobutton.IsChecked==true)
                {
                    return radiobutton.Content.ToString();
                }
            }
            return "";
        }
    }
}
