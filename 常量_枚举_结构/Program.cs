using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常量
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            const int number2 = 20;
            //number2 = 20;//常量不能被重新赋初值
            Console.WriteLine(number2);
            Console.ReadKey();

        }
    }
}
