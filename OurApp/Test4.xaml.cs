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
    /// Логика взаимодействия для Test4.xaml
    /// </summary>
    public partial class Test4 : Window
    {
        public Test4()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
                RadioButton RadButt = (RadioButton)sender;
                if(RadButt.IsChecked == true)
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Test5 test5 = new Test5();
            test5.Show();
            this.Close();
        }
    }
}
//Title = "Test" Height = "450" Width = "450" >

//< Grid ShowGridLines = "True" >

// < Grid.RowDefinitions >

//     < RowDefinition Height = "87*" ></ RowDefinition >

//     < RowDefinition Height = "87*" ></ RowDefinition >

//     < RowDefinition Height = "87*" ></ RowDefinition >

//     < RowDefinition Height = "87*" ></ RowDefinition >

//     < RowDefinition Height = "87*" ></ RowDefinition >

//     < RowDefinition Height = "87*" ></ RowDefinition >

// </ Grid.RowDefinitions >

// < Grid.ColumnDefinitions >

//     < ColumnDefinition Width = "109*" ></ ColumnDefinition >

//     < ColumnDefinition Width = "341*" />

// </ Grid.ColumnDefinitions >

// < Label Grid.Row = "0" Grid.Column = "1" Content = "exmplqyestion" Margin = "72,15,0,0" HorizontalAlignment = "Left" VerticalAlignment = "Top" />

// < StackPanel Grid.Row = "1" Grid.Column = "1" >

//     < RadioButton Content = "Выбран" Checked = "RadioButton_Checked" />

//     < RadioButton Content = "Не выбран" Checked = "RadioButton_Checked" />

//     < RadioButton Content = "Не определен" Checked = "RadioButton_Checked" />

// </ StackPanel >

// < Label Grid.Row = "2" Grid.Column = "1" Content = "exmplqyestion" Margin = "72,15,0,0" HorizontalAlignment = "Left" VerticalAlignment = "Top" />

// < StackPanel Grid.Row = "3" Grid.Column = "1" >

//     < RadioButton Content = "Выбран" Checked = "RadioButton_Checked_1" />

//     < RadioButton Content = "Не выбран" Checked = "RadioButton_Checked_1" />

//     < RadioButton Content = "Не определен" />

// </ StackPanel >

// < Label Grid.Row = "4" Grid.Column = "1" Content = "exmplqyestion" Margin = "72,15,0,0" HorizontalAlignment = "Left" VerticalAlignment = "Top" />

// < StackPanel Grid.Row = "5" Grid.Column = "1" >

//     < RadioButton Content = "Выбран" />

//     < RadioButton Content = "Не выбран" Checked = "RadioButton_Checked_2" />

//     < RadioButton Content = "Не определен" Checked = "RadioButton_Checked_2" />

// </ StackPanel >

// < Button Grid.Column = "0" Grid.Row = "5" Content = "На следующую-->" />

//</ Grid >