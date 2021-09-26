using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_判断一个年份是不是闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("请输入一个年份");
            //    try
            //    {
            //        int year = Convert.ToInt32(Console.ReadLine());
            //        bool a = Program.IsRun(year);
            //        if (a)
            //        {
            //            Console.WriteLine("{0}这一年是闰年", year);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0}这一年不是闰年", year);
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入错误，程序退出");
            //    }
            //    Console.ReadKey();

            //}
            ////public static 返回值类型 方法名（参数列表）//如果没有返回值则返回值类型填写void
            ///// <summary>
            ///// 判断某一年是否是闰年
            ///// </summary>
            ///// <param name="year"></param>
            ///// <returns>返回一个bool型，true代表是闰年</returns>
            //public static bool IsRun(int year)
            //{
            //    bool a = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //    return a;
            //}

            int a1 = 10;
            int a2 = 20;
            int max = GetMax(a1, a2);//实参--实际上的参数
            Console.WriteLine(max);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算两个整数之间的最大值，并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <retrns>将最大值返回</retrns>
        public static int GetMax(int n1, int n2)//形参---形式上的参数
        {
            int max = n1 > n2 ? n1 : n2;//return在这里的作用是返回要返回的值
            return max;
        }
    }
}
