using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //从标准输入读取一行字符串
            string str = Console.ReadLine();

            //获取字符串长度
            int len = str.Length;
            Console.WriteLine($"length:{len}");

            //查找字母字符
            int alphaCount = 0; int numPos = 0; int numberCount = 0; int otherCount = 0;
            int alphaPos = 0;
            int[] numArray = new int[len];
            int[] alphaArray = new int[len];
            for(int i = 0; i < len; i++)
            {
                //是否是数字
                if (Char.IsNumber(str[i]) == true)
                {
                    numArray[numPos++] = str[i] - 48;
                    numberCount++;
                }
                else
                {
                    otherCount++;
                    //是否是字符
                    if (char.IsLetter(str[i]) == true)
                    {
                        alphaCount++;
                        alphaArray[alphaPos++] = i;
                    }
                }
                
            }

            Console.WriteLine("--------");

            if (numberCount == 0)
                Console.WriteLine("numberCount:-1");
            else
            {
                for (int i = 0; i < numPos; i++) Console.Write($"{numArray[i]} ");
            }


            if(alphaCount == 0)
                Console.WriteLine("alphaCount:-1");
            else
            {
               Console.WriteLine($"alphaCount:{alphaCount}");
                for (int i = 0; i < alphaPos; i++) Console.Write($"{alphaArray[i]} ");
            }

            Console.WriteLine("\n------");

            //拼接
            Console.WriteLine(str + "C#");
        }
    }
}