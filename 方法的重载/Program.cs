using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //M(); //M当中可以传入四种不同类型的参数
            //对着WriteLine按F12可以查看源代码，发现其也是方法的重载
            Console.WriteLine(1);
            Console.WriteLine(1.3);
            Console.WriteLine('s');
            Console.WriteLine("asd");
            Console.WriteLine(5000m);
            Console.ReadKey(true);

        }

        //四个“相加”的方法，在使用的时候，需要调用不同的M1 M2 M3 M4方法
        //而要实现自动根据数据类型调用可以的方法，需要用到方法的重载
        public static void M(int n1, int n2)//1)、如果参数的个数相同，那么参数的类型就不能相同。
                                            //2)、如果参数的类型相同，那么参数的个数就不能相同。

        {
            int result = n1 + n2;
        }
        public static double M(double d1, double d2)//1)、如果参数的个数相同，那么参数的类型就不能相同。
                                                    //2)、如果参数的类型相同，那么参数的个数就不能相同。
        {
            return d1 + d2;
        }
        public static void M(int n1, int n2, int n3)//1)、如果参数的个数相同，那么参数的类型就不能相同。
                                                    //2)、如果参数的类型相同，那么参数的个数就不能相同。
        {
            int result = n1 + n2 + n3;
        }
        public static string M(string s1, string s2)//1)、如果参数的个数相同，那么参数的类型就不能相同。
                                                    //2)、如果参数的类型相同，那么参数的个数就不能相同。
        {
            return s1 + s2;
        }
    }
}
