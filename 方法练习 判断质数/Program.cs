using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_判断质数
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个数字，我们将判断你输入的数字是否是质数
            Console.WriteLine("请输入一个数字，判断这个数字是否是质数");
            string num = Console.ReadLine();
            int number = GetNumber(num);
            bool b = IsPrimeNumber(number);
            Console.WriteLine(b);
            Console.ReadKey(true);
        }
        public static bool IsPrimeNumber(int number)
        {
            bool b = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    b = false;
                    break;
                }
            }
            return b;
        }
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;//因为有return的原因，所以前面的while中即使是true也可以跳出该循环
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
