using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_函数_练习
{
    class Program
    {
        //        //public static 返回值类型 方法名（[参数列表]）
        //        {
        //        方法体;
        //        }
        static void Main(string[] args)
        {
            //计算两个整数之间的最大值
            int max = Program.GetMax(1, 3);
            Console.WriteLine(max);//是一个有参数，没有返回值的方法
            Console.ReadKey();
            //int n = Convert.ToInt32("123");
            //string str =Console.ReadLine(); 
        }
        /// <summary>
        /// 计算两个整数之间的最大值，并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <retrns>将最大值返回</retrns>
        public static int GetMax(int n1, int n2)//int代表返回值类型。如果不需要返回值 则用void
        {
            return n1 > n2 ? n1 : n2;//return在这里的作用是返回要返回的值
        }
    }
}
