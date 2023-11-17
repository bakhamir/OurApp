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
    /// Логика взаимодействия для Test3.xaml
    /// </summary>
    public partial class Test3 : Window
    {
        public Test3()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                CheckBox chBox  = (CheckBox)sender;
                if(chBox.IsChecked == true)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно!");
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked == true)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно!");
            }
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked == true)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно!");
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Test4 test4 = new Test4();
            test4.Show();
            this.Close();
        }
    }
}
