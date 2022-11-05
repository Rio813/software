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

namespace 属性和方法
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //窗体加载

            //添加标题
            listbox.Items.Add("课程名\t\t开设学期\t书名\t\t定价");

            //对象1
            CourseInfo courseInfo = new CourseInfo();
            courseInfo.CourseName = "数据结构";
            courseInfo.CourseTime = CourseBeginTime.秋季;
            courseInfo.BookName = "《数据结构》";
            courseInfo.Price = 40;

            //对象2
            CourseInfo courseInfo2 = new CourseInfo("操作系统", CourseBeginTime.秋季, "《操作系统》", 45);

            //对象3
            CourseInfo courseInfo3 = new CourseInfo();
            courseInfo3.CourseName = "软件工程";
            courseInfo3.CourseTime = CourseBeginTime.春季;
            courseInfo3.BookName = "《软件工程》";
            courseInfo3.Price = 38;

            //显示信息
            listbox.Items.Add(courseInfo.Print());
            listbox.Items.Add(courseInfo2.Print());
            listbox.Items.Add(courseInfo3.Print());

        }
    }
}
