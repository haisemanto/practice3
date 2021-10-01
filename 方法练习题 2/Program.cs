using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法GetNumber
{
    class Program
    {//读取用户输入的整数，定义成方法，多次调用，(如果用户输入的是数字，则返回，否则提示用户输入)

        static void Main(string[] args)
        {
            //string strNumber = "";
            //do
            //{
            //    Console.WriteLine("请输入一个数字，如果不是数字，则重新输入");
            //    strNumber = Console.ReadLine();
            //    //bool a = Program.IsNumber(strNumber);
            //} while (Program.IsNumber(strNumber));
            //Console.WriteLine("输入的是数字，程序退出");
            //Console.ReadKey();
            Console.WriteLine("请输入一个数字");
            string input = Console.ReadLine();
            int num = Program.GetNumber(input);//调用方法的括号里填写传入的参数
            Console.WriteLine(num);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断输入的字符串是否为数字
        /// </summary>
        /// <param name="s">输入一个字符串</param>
        /// <returns>返回一个string转换成功的整型变量</returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }



        /// <summary>
        /// 判断输入的字符串是不是整型
        /// </summary>32
        /// <param name="strNumber">输入的字符串</param>
        /// <returns>返回一个bool型</returns>
        public static bool IsNumber(string strNumber)
        {
            try
            {
                int number = Convert.ToInt32(strNumber);
                return false;
            }
            catch
            {
                return true;
            }


        }
        //方法中 最忌讳的就是出现提示用户输入等字样 如下
        //private static void IsNumber()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("请输入一个数字");
        //        try
        //        {
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine(number);
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入有误");
        //        }


        //    }
    }
}

