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

namespace BMI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput;
        double douOutput;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtButton_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(txtHeight.Text, out double Height_cm) && Height_cm > 0 && Height_cm < 250)
            {
                double Height_m = Height_cm / 100;
                if(double.TryParse(txtWeight.Text, out double Weight) && Weight > 0 && Weight < 600)
                {
                    double BMI = Weight / (Height_m * Height_m);
                    txtBMI.Text = BMI.ToString("0.##");
                }
                else
                {
                    txtBMI.Text = "體重輸入錯誤";
                }
            }
            else
            {
                txtBMI.Text = "身高輸入錯誤";
            }
        }
    }
}
