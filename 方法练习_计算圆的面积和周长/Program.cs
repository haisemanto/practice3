using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_计算圆的面积和周长
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            int r= 0;
            double s;
            double c;
            while (b)
            {
                Console.WriteLine("请输入要判断圆的面积");
                string number = Console.ReadLine();
                r = GetNumber(number);
                if (r >= 0)
                {
                    b = false;
                }
            }
            CountS(r, out s);
            CountC(r, out c);
            Console.WriteLine("圆的面积是{0:0.00}，圆的周长是{1:0.00}", s, c);
            Console.ReadKey(true);


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
        public static void CountC(int r, out double s)
        {
            s = 2 * Math.PI * r;
        }
        public static void CountS(int r, out double c)
        {
            c = Math.PI * r * r;
        }
    }

}
