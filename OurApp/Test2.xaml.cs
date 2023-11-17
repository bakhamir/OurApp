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
    /// Логика взаимодействия для Test2.xaml
    /// </summary>
    public partial class Test2 : Window
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
               string answer = "asdd";
               var item = (TextBox)cb1.SelectedItem;
            if (item.Text == answer)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно!");
            }

        }

        private void cb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string answer = "czx";
            var item = (TextBox)cb2.SelectedItem;
            if (item.Text == answer)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно!");
            }
        }

        private void cb3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string answer = "yer";
            var item = (TextBox)cb3.SelectedItem;
            if (item.Text == answer)
            {
                MainWindow.Points++;
                MessageBox.Show("Верно!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test3 test3 = new Test3();
            test3.Show();
            this.Close();
        }
    }
}
