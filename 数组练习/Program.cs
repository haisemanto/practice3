using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组练习
{

    class Program
    {

        static void Main(string[] args)
        {
            //从一个整数数组中取出最大的整数，最小的整数，总和，平均值，随机数
            //int[] nums = new int[10];
            int[] nums = { -3, -2, -5, -4, -9, -6, -5, -7, -7, -2, -9, -10 };//随意赋初值
            double sum = 0;//求平均值，习惯用double变量来定义

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i + 1;
            //}
            int max = nums[0];
            int min = nums[0];
            //关于nums[i]在循环中的理解方式
            //1.代表数组中当前循环到的元素
            //2.代表数组中的每一个元素
            for (int i = 0; i < nums.Length; i++)
            {

                sum += nums[i];
                //以下代码用来判定总和

                //以下代码用来判定最大值        
                if (nums[i] > max)//循环的让数组中的每个元素和我的最大值进行比较
                {
                    max = nums[i];

                }
                //以下代码用来判定最小值
                else if (nums[i] < min)//循环的让数组中的每个元素和我的最小值进行比较
                {

                    min = nums[i];

                }
                else
                {
                    continue;
                }
                if (i == nums.Length - 1)
                {
                    Console.WriteLine("这个数组的长度是{0}", nums.Length);
                    Console.WriteLine("这个数组中最大的数是{0}", max);
                    Console.WriteLine("这个数组中最小的数是{0}", min);
                    Console.WriteLine("这个数组的总和为{0}", sum);
                    Console.WriteLine("这个数组的平均值是{0:0.00}", sum / nums.Length);
                    Random r = new Random();//调用Random方法来生成一个随机数
                    int rNumber = r.Next(1, 13);
                    Console.WriteLine("随机产生的一个数组中的数是{0}", nums[rNumber]);
                }

            }
            Console.ReadKey(true);

        }
    }
}
