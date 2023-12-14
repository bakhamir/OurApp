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
    /// Логика взаимодействия для Ende.xaml
    /// </summary>
    public partial class Ende : Window
    {
        public Ende()
        {
            InitializeComponent();
        }

        private void getRes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nameTitle.Content =$"поздравляем {MainWindow.Name} с прохождением теста!";
            scoreTitle.Content = $"{MainWindow.Points}/15";
        }
    }
}
