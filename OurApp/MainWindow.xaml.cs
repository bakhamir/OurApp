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

namespace OurApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        public static new string Name = "";
        public static int Points = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name = nameBox.Text;
            Test2 test2 = new Test2();
            test2.Show();
            this.Close();
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var item = (TextBox)people.SelectedItem;
        //    MessageBox.Show(item.Text);
        //}

        //private void cbt1_Checked(object sender, RoutedEventArgs e)
        //{
        //    CheckBox chBox  = (CheckBox)sender;
        //    MessageBox.Show(chBox.Content.ToString());
        //}

        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    RadioButton RadButt = (RadioButton)sender;
        //    MessageBox.Show(RadButt.Content.ToString());
        //}

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    Slider slider = (Slider)sender;
        //    MessageBox.Show(slider.Value.ToString());
        //}

        //private void pb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{

        //}

        //private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    Slider s = (Slider)sender;
        //    pb.Value = s.Value;
        //}
    }
}
