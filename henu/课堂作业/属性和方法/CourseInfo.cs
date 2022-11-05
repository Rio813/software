using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性和方法
{
    //声明一个CourseBeingTime类型
     enum CourseBeginTime { 秋季, 春季};

     class CourseInfo
    {
        public string CourseName { get; set; }
        public CourseBeginTime CourseTime { get; set; }
        public string BookName { get; set; }

        public double Price { get; set; }

        public static int Counter;
        

        public CourseInfo() { Counter++; }

        public CourseInfo(string CourseName, CourseBeginTime CourseTime, string BookName, double Price)
        {
            this.CourseName = CourseName;
            this.CourseTime = CourseTime;
            this.BookName = BookName;
            this.Price = Price;
            Counter++;
        }

        public string Print()
        {
            return string.Format("{0}\t {1}\t            {2}\t{3}", CourseName, CourseTime, BookName, Price);
        }
    }
}
