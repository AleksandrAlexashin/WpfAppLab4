using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)

        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble = rateEuro * sumEuro;
            resSum1.Text = resDouble.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGBP = Convert.ToDouble(rate2.Text);
            double sumGBP = Convert.ToDouble(sum2.Text);
            double resDouble = rateGBP * sumGBP;
            resSum2.Text = resDouble.ToString();


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateCNY = Convert.ToDouble(rate3.Text);
            double sumCNY = Convert.ToDouble(sum3.Text);
            double resDouble = rateCNY * sumCNY;
            resSum3.Text = resDouble.ToString();
            
        }

        private void Button_Click_distance(object sender, RoutedEventArgs e)

        {
            double distanceInch = Convert.ToDouble(inch.Text);
             resMetr.Text = (distanceInch / 39.37008).ToString();

        }

        private void Button_Click_distance1(object sender, RoutedEventArgs e)
        {
            double distanceMile = Convert.ToDouble(mile.Text);
            resMetr1.Text = (distanceMile * 1609.34).ToString();

        }
        private void Button_Click_distance2(object sender, RoutedEventArgs e)
        {
            double distanceFoot = Convert.ToDouble(foot.Text);
            resMetr2.Text = (distanceFoot / 3.28084).ToString();

        }
        private void Button_Click_distance3(object sender, RoutedEventArgs e)
        {
            double distanceSeaMile = Convert.ToDouble(sea_mile.Text);
            resMetr3.Text = (distanceSeaMile * 1852).ToString();

        }
        
    }
}
