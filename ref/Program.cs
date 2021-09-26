using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用ref方法来交换两个int类型的变量
            int a = 10;
            int b = 20;
            Exchange(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey(true);
        }
        public static void Exchange(ref int a,ref int b)//ref方法要求必须在方法外部赋值
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
