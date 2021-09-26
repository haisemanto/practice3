using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习题3_数组的传参
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            //计算输入数组的和
            Console.WriteLine("请输入10个数字");
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    Console.WriteLine("请输入第{0}个数字",i+1);
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入");
                    i--;
                }
            }
            int sum =Program.Sum(nums);//调用方法的括号里填写传入的参数
            Console.WriteLine("输入的数组是");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine("输入数组的总和是{0}",sum);
            Console.ReadKey(true);
        }
        //public static 返回值类型 方法名（参数列表）//如果没有返回值则返回值类型填写void
        /// <summary>
        /// 计算传入数组的各个元素总和
        /// </summary>
        /// <param name="nums">传入的数组</param>
        /// <returns>输出一个int型的总数</returns>
        public static int Sum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
