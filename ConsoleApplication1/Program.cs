using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //非第三方变量，两个int类型的交换
            int a = 20;
            int b = 80;
            a = a - b;//a=-60 b = 80;
            b = a + b;//b=20;a=-20
            a = b - a;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
