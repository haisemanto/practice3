using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_反转字符串数组中的字符
{
    class Program
    {
        static void Main(string[] args)
        //            请将字符串数组{ "中国"，"美国"，“巴西"，“澳大利亚"，“加拿大" }中的内容反转
        {
            string[] countries = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            ReverseNames(countries);
            for (int i = 0; i < countries.Length; i++)
            {
                Console.Write("{0},", countries[i]);
            }
            Console.ReadKey(true);
            Console.ReadKey(true);

        }
        public static void ReverseNames(string[] names)//数组可以不需要有返回值，
                                                       //单纯就相当于把数组用方法进行了一个处理
        {
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp;
                temp = names[i];
                names[i] = names[names.Length - i - 1];
                names[names.Length - i - 1] = temp;
            }
        }
    }
}
