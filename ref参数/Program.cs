using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey(true);


        }
        public static void JiangJin(ref double s)//此方法没有返回任何值，但是用ref传参就会让其返回，比更改void方便很多
        {
            s+= 500;
        }
        public static double JiangJin2 (double s)//此方法没有返回任何值，因此调用此方法不会返回任何值
        {
            s += 500;
            return s;
        }
    }
}
