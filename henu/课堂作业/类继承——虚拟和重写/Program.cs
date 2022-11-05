using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类继承__虚拟和重写
{
    public class program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.MyMethod(10);
            Console.WriteLine(d.Result);
            E e = new E();
            e.MyMethod(10);
            Console.WriteLine(e.Result);
        }

    }
}