using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法最后的练习3
{
    class Program
    {
        static void Main(string[] args)
        {//用方法来实现：计算一个整型数组的平均值，保留两位小数
            int[] numbers = { 1, 2, 7 };
            double avg = GetAvg(numbers);
            Console.WriteLine(avg);
            Console.ReadKey(true);


        }
        /// <summary>
        /// 给定一个整型数组，计算其平均值，保留两位输出
        /// </summary>
        /// <param name="nums">给定的数组</param>
        /// <returns>返回一个double类型 保留两位小数的双精度浮点型变量</returns>
        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            string s = (sum / nums.Length).ToString("0.00");//把double类型转换为保留两位小数的string类型.并赋值给s
            double avg = Convert.ToDouble(s);
            return avg;
        }
    }
}
