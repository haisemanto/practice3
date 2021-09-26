using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] s = {90, 80, 70};
            Test("张三", 90, 100, 100, 100);//实参列表
            Console.ReadKey(true);
            //int[] s = {90, 80, 70};
            //Test("张三",s);
            //Console.ReadKey(true);
        }
        public static void Test(string name, int id, params int[] score)//把传参的int型数字当做这个数组的元素传参
                                                                        //params可变参数必须是形参列表中的最后一个参数
                                                                        //params int[] score可变参数数组（可以改变参数的数组）
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1}学号是{2}", name, sum, id);
        }
    }
}
