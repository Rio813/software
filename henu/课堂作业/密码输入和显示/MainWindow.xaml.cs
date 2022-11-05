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

namespace 密码输入和显示
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate(object sender, RoutedEventArgs e)
        {
            double x, y, z = 0;
            String firstNum = X.Text;
            String secondNum = Y.Text;

            bool IsFristNum = double.TryParse(firstNum, out x);
            bool IsSecondNum = double.TryParse(secondNum, out y);

            if (IsFristNum && IsSecondNum)
            {
                if (AddBtn.IsChecked == true) z = x + y;
                if (SubBtn.IsChecked == true) z = x - y;
                if (MulBtn.IsChecked == true) z = x * y;
                if (DivBtn.IsChecked == true) z = x / y;
                if (ModBtn.IsChecked == true) z = x % y;
                Z.Text = z.ToString();
            }
            else
            {
                Z.Text = "?";
            }

        }

        private void AddBtn_Checked(object sender, RoutedEventArgs e)
        {
            
            MyLabel.Content = "+";
        }
        private void SubBtn_Checked(object sender, RoutedEventArgs e)
        {
            MyLabel.Content = "-";
        }
        private void MulBtn_Checked(object sender, RoutedEventArgs e)
        {
            MyLabel.Content = "*";
        }

        private void DivBtn_Checked(object sender, RoutedEventArgs e)
        {
            MyLabel.Content = "/";
        }

        private void Z_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void ModBtn_Checked(object sender, RoutedEventArgs e)
        {
            MyLabel.Content = "%";
        }
    } 
}
