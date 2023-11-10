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

namespace DZ_var10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (
                double.TryParse(Distance1TextBox.Text, out double distance1) &&
                double.TryParse(Speed1TextBox.Text, out double speed1) &&
                double.TryParse(Distance2TextBox.Text, out double distance2) &&
                double.TryParse(Speed2TextBox.Text, out double speed2) &&
                double.TryParse(Distance3TextBox.Text, out double distance3) &&
                double.TryParse(Speed3TextBox.Text, out double speed3)
                )
            {
                double t1 = distance1 / speed1;
                double t2 = distance2 / speed2;
                double t3 = distance3 / speed3;
                double averageSpeed = (distance1 + distance2 + distance3) / (t1 + t2 + t3);
                averageSpeed = Math.Round(averageSpeed, 2);
                ResultLabel.Text = $"Средняя скорость автомобиля: {averageSpeed} км/ч";
            }
            else
            {
                ResultLabel.Text = "Ошибка: Введите корректные данные.";
            }
        }
    }
}
