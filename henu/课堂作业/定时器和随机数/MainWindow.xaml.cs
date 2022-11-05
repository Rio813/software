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
using System.Windows.Threading;

namespace 定时器和随机数
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RandomHelp randomHelp = new RandomHelp();
        DispatcherTimer dt = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            res.Content = "0";
            res.FontSize = 10;
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
                //更新整数
                RandomHelp.GetIntRandomNumber();
                //更新实数
                RandomHelp.GetDoubleRandomNumber();
        }

        private void begin_btn_Click(object sender, RoutedEventArgs e)
        {
            //数据有效性
            int x = 0, y = 0, z = 0;
            String firstNum = min_text.Text;
            String secondNum = max_text.Text;
            String thirdNum = time_text.Text;

            bool ifMinNum = int.TryParse(firstNum, out x);
            bool ifMaxNum = int.TryParse(secondNum, out y);
            bool ifTimeNum = int.TryParse(thirdNum, out z);

            ifMinNum = ifMinNum && x > 0;
            ifMaxNum = ifMaxNum && y > 0;
            ifTimeNum = ifTimeNum && z > 0;

            if (ifMinNum && ifMaxNum && ifTimeNum)
            {
                RandomHelp.begin = x;
                RandomHelp.end = y;

                //时间间隔
                dt.Interval = TimeSpan.FromSeconds(z);
                dt.Tick += Dt_Tick;
                dt.Start(); 
            }
            else
            {
                if (ifMinNum == false) min_text.Text = "?";
                if (ifMaxNum == false) max_text.Text = "?";
                if (ifTimeNum == false) time_text.Text = "?";
            }
        }


        private void stop_btn_Click(object sender, RoutedEventArgs e)
        {
            //显示
            dt.Stop();
            if (int_radio.IsChecked == true)
                res.Content = RandomHelp.randomNumber;
            else
                res.Content = RandomHelp.doubleRandomNumber;

            res.FontSize = 20;

        }
    }
}
