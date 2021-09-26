using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，求一个数组中的最大值，最小值，总和，平均值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] res=GetMaxMinSumAvg(nums);
            //将要返回的四个值放到一个数组中返回
            //Console.WriteLine("最大值为{0}，最小值为{1}，总和为{2}，平均值为{3}",res[0],res[1],res[2],res[3]);
            //Console.ReadKey(true);
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max1 ;
            int min1 ;
            int sum1 ;
            int avg1 ;//以上四个值均在Test方法里赋值了
            bool b;
            string s;
            double d;
            Test(nums,out max1,out min1,out sum1,out avg1,out b, out s, out d);//传参的时候在变量前面加上out，表示这个参数是方法内部多余返回的
            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.ReadKey(true);





        }
        //public static 返回值类型 方法名（参数列表）//如果没有返回值则返回值类型填写void
        /// <summary>
        /// 求给定数组的最大值，最小值，总和，平均数。
        /// </summary>
        /// <param name="nums">输入一个int[]数组</param>
        /// <returns>返回一个数组，其中res[0],res[1],res[2],res[3]分别代表最大值，最小值，总和以及平均数</returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];//声明一个长度为4的数组
                                   //假设res[0]存最大值
                                   //假设res[1]存最小值
                                   //假设res[2]存总和
                                   //假设res[3]存平均值
            res[0] = nums[0];
            res[1] = nums[0];
            res[3] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res[2] += nums[i];
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                else if (nums[i] < res[1])
                {
                    res[1] = nums[i];
                }

            }
            res[3] = res[2] / nums.Length;
            return res;
        }
        /// <summary>
        /// 计算一个整数数组的最大值，最小值，总和，平均值
        /// </summary>
        /// <param name="nums">输入的数组</param>
        /// <param name="max">输出的最大值</param>
        /// <param name="min">输出的最小值</param>
        /// <param name="sum">输出的总和</param>
        /// <param name="avg">输出的平均值</param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg,out bool b, out string s, out double d)//先在形参列表里用out参数写上要多余返回的参数
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (max < nums[i])
                {
                    max = nums[i];
                }
                else if (min > nums[i])
                {
                    min = nums[i];
                }
                
            }
            avg = sum / nums.Length;
            b = true;//前面不需要加数据类型名称bool 因为已经在方法内部声明了，此处只需要赋值即可，下同
            s = "sss";//同上
            d = 3.14;//同上
        }
    }
}
