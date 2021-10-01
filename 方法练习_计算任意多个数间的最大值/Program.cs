using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_计算任意多个数间的最大值
{
    class Program
    {
        //用params可变参数来实现
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            GetMax(nums);
            Console.ReadKey(true);


        }
        public static void GetMax(params int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("这个数组中，最大的数是{0}",max);
        }
    }
}
