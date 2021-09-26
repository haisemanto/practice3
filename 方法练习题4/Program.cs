using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习题4
{
    class Program
    {
        static void Main(string[] args)
        {//定义一个方法，之能允许用户输入yes或no并返回输入值
            Console.WriteLine("请输入yes/no");
            string input = Console.ReadLine();
            string strout =IsYesOrNo(input);
            Console.WriteLine("用户输入的最终数据是{0}",strout);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断用户输入的是yes/no 如果不是，则重复输入
        /// </summary>
        /// <param name="s">传入的参数input</param>
        /// <returns>返回用户输入的yes/no</returns>
        public static string IsYesOrNo(string s)//形参
        {
            while (true)
            {
                if (s == "yes" || s == "no")
                {
                    return s;
                }
                else
                {
                    Console.WriteLine("请重新输入");
                    s=Console.ReadLine();
                }
            }

        }
    }
}
