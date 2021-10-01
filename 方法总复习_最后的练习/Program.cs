using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_计算这两个数字之间所有整数的和
{
    class Program
    {
        //public static int n1;
        //public static int n2;
        static void Main(string[] args)
        {
            //提示用户输入两个数字 计算这两个数字之间，所有整数的和
            //1.用户只能输入数字
            //2.计算两个数字之间的和
            //3.要求第一个数字必须比第二个数字小，否则重新输入
            bool result = false;
            while (!result)
            {
                int n1;
                int n2;

                Console.WriteLine("输入两个数字，并计算两个数字之间所有整数的总和");
                string strNumber1 = Console.ReadLine();
                n1 = GetNumber(strNumber1);
                string strNumber2 = Console.ReadLine();
                n2 = GetNumber(strNumber2);
                result = JudgeNumber(n1, n2, result);
                if (result)
                {
                    int sum = 0;
                    Sum(n1, n2, ref sum);
                    Console.WriteLine(sum);
                    Console.ReadKey(true);
                }
            }

        }
        /// <summary>
        /// 计算从n1到n2的所有整数的和。n1<n2
        /// </summary>
        /// <param name="n1">第一个数字</param>
        /// <param name="n2">第二个数字</param>
        /// <param name="sum">输出的数字总和</param>
        public static void Sum(int n1, int n2, ref int sum)
        {
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
        }
        /// <summary>
        /// 将给定的字符串转变成整型数字（带trycatch异常捕获）
        /// </summary>
        /// <param name="s">传入的string型字符串</param>
        /// <returns>返回一个转变成功的整型变量</returns>
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
        /// <summary>
        /// 比较给定数字的大小，当第一个数字小于第二个数字是，返回一个布尔型变量true
        /// </summary>
        /// <param name="n1">第一个数字</param>
        /// <param name="n2">第二个数字</param>
        /// <param name="result">输出的bool型变量</param>
        /// <returns></returns>
        public static bool JudgeNumber(int n1, int n2, bool result)
        {
            result = n1 < n2 ? true : false;
            if (!result)
            {
                Console.WriteLine("第一个数字不能大于或者等于第二个数字，请重新输入");
            }
            //false表示符合题意，n1<n2
            return result;
        }
    }
}
