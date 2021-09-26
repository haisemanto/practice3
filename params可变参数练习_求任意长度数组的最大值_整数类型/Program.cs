using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params可变参数练习_求任意长度数组的最大值_整数类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //求任意长度数组的最大值_整数类型
            int max;
            AnyNum(out max,32,45,23,54,65,87,34,76);
            Console.ReadKey(true);
        }
        public static void AnyNum(out int max,params int[] nums)
        {
            max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
