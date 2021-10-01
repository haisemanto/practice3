using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 2, 7, 5, 8, 3, 9, 6, 0, 3, 6, 2 };
            BubbleSort(nums, ref nums);
            Console.WriteLine("从小到大排列后的顺序为");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.ReadKey(true);

        }
        public static void BubbleSort(int[] s, ref int[] nums)
        {
            int temp;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (s[j] > s[j + 1])
                    {
                        temp = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = temp;
                    }
                }

                nums = s;
            }
        }
    }

}
