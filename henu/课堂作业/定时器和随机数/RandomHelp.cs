using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定时器和随机数
{
    class RandomHelp
    {
        static Random random = new Random();
        public static int begin = 0;
        public static int end = 100;
        public static int randomNumber = 5;
        public static double doubleRandomNumber = 50; 
        public static void GetIntRandomNumber()
        {
            randomNumber = random.Next(begin, end);            
        }

        public static void GetDoubleRandomNumber()
        {
            doubleRandomNumber = random.NextDouble() + random.Next(begin, end - 1);
        }
    }
}
