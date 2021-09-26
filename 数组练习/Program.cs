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
            #region 练习1：数组输出最大值 最小值 总和 平均数 以及随机生成随机数
            ////从一个整数数组中取出最大的整数，最小的整数，总和，平均值，随机数
            ////int[] nums = new int[10];
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
            #endregion
            #region 练习2：数组里都是人的名字，老杨，老张，老苏，老赵，老陈...将其输出为老杨|老陈。。。
            // //数组类型[] 数组名=new 数组类型[数组长度];
            // string[] names = new string[] { "老杨","老陈","老李","老吴","老徐","老苏","老八"};
            // Console.WriteLine("数组的长度是{0}",names.Length);
            // //第一个方法
            // for (int i = 0; i < names.Length; i++)
            // {
            //     Console.Write(names[i]);
            //     if (i==names.Length-1)//最后一个不需要用|分割，所以当输出到最后一个时，直接跳出循环
            //     {
            //         Console.WriteLine("\r");
            //         break;
            //     }
            //     Console.Write("|");
            // }

            ////第二个方法
            // string str = null;
            // for (int i = 0; i < names.Length-1; i++)
            // {
            //     str += names[i] + "|";
            // }
            // Console.WriteLine(str+names[names.Length-1]);
            // Console.ReadKey();

            #endregion
            #region 练习3：将一个整数数组的元素进行如下处理：
            ////如果元素是正数，则将这个位置的元素加1
            ////如果这个元素是负数，则将这个位置的元素减1
            ////如果这个位置的元素是0，则不变
            ////数组类型[] 数组名=new 数组类型[数组长度];
            //int[] nums = new int[10] { 5,3,-3,1,0,0,-4,3,-1,-8};
            //int[] nums2 = new int[10];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums2[i] = nums[i] + 1;
            //    }
            //    else if (nums[i]<0)
            //    {
            //        nums2[i] = nums[i] - 1;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //Console.Write(nums[i]+"|");
            //    //Console.WriteLine("\r");
            //    Console.Write(nums2[i]);
            //    if (i==nums2.Length)
            //    {
            //        break;
            //    }
            //    Console.Write("|");
            //}
            //Console.ReadKey(true);




            #endregion
            #region 将一个字符串数组里的元素的顺序进行反转。
            //{"我""是""好人"}-->{"好人""是""我"}
            //数组类型[] 数组名=new 数组类型[数组长度];
            //string[] names = new string[] { "我", "爱", "你","你","爱","我","蜜雪冰城","甜蜜蜜" };//0 1 2
            //string[] names2 = new string[names.Length];
            //Console.WriteLine("数组的长度是" + names.Length);
            /////以下方法定义了一个新的字符串数组来存储交换顺序后的字符串
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names2[i] = names[names.Length-1-i];
            //}
            ////Console.WriteLine("第一个字符串数组的输出");
            ////for (int i = 0; i < names2.Length; i++)
            ////{                
            ////    Console.Write(names[i]);
            ////}
            ////Console.WriteLine("\r\n交换后的字符串输出");//转义字符\r\n可以实现换行的作用
            ////for (int i = 0; i < names2.Length; i++)
            ////{
            ////    Console.Write(names2[i]);
            ////}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = names2[i];
            //}
            //Console.WriteLine("\r\n交换后的字符串输出");//转义字符\r\n可以实现换行的作用
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write(names[i]);
            //}
            //Console.ReadKey(true);


            //以下采用定义一个用于交换的第三方字符串 temp提供交换
            //string[] names = new string[] { "我", "爱", "你", "你", "爱", "我", "蜜雪冰城", "甜蜜蜜" };//0 1 2
            ////string[] names2 = new string[names.Length];
            //Console.WriteLine("数组的长度是" + names.Length);
            //for (int i = 0; i < names.Length/2; i++)//这里让names.Lenth/2 不然他会循环交换两次导致白忙活
            //{
            //    string temp = names[i];
            //    names[i] = names[names.Length - 1 - i];
            //    names[names.Length- 1 - i] = temp;
            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write(names[i]);
            //}
            //Console.ReadKey(true);


            #endregion
        }
    }
}
