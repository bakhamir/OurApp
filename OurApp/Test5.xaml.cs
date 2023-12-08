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

namespace OurApp
{
    /// <summary>
    /// Логика взаимодействия для Test5.xaml
    /// </summary>
    public partial class Test5 : Window
    {
        public Test5()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton RadButt = (RadioButton)sender;
            if (RadButt.IsChecked == true)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно");
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton RadButt = (RadioButton)sender;
            if (RadButt.IsChecked == true)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно");
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            RadioButton RadButt = (RadioButton)sender;
            if (RadButt.IsChecked == true)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно");
            }
        }
    }
}
