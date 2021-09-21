using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复杂数据类型_数组的定义
{
    class Program
    {
        static void Main(string[] args)
        {
            ////数组类型[] 数组名=new 数组类型[数组长度];
            ////现在要一次性存储十个int型的变量。
            //int[] nums = new int[10];
            ////在给数组中的每一个元素赋值的时候，如果一个一个来，会很麻烦，所以可以采用循环结构来进行

            ////我们通过一个循环对数组进行赋值，同样也可以通过一个循环对数组进行取值
            //for (int i = 0; i < nums.Length; i++)//简单点可以写10，洋气点可以写nums.Length
            //{
            //    nums [i]= i;
            //}
            //nums[10] = 10;//数组长度一旦固定了，就不能再被改变。
            //for (int i = 0; i < nums.Length; i++)//用for循环来进行取值
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            //string[] str = new string[10];//
            //bool[] bools = new bool[10];
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //    //Console.WriteLine(bools[i]);
            //}
            //Console.ReadKey();


            //数组的声明方式
            int[] nums = new int[10];//声明的时候只限定好长度
            //数组类型[] 数组名=new 数组类型[数组长度]

            int[] numsTwo = { 1, 2, 3, 4, 5, 6, 7 };//声明的时候直接赋初值
            int[] numsThreee = new int[3] { 1, 2, 3 };//本质上跟上一种一样，但是写起来比较麻烦
            int[] numsFour = new int[] { 1, 2, 3, 4, 5, 6 };





        }
    }
}
