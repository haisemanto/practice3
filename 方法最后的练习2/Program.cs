using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_输出字符串数组中最长的字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现有一个字符串数组
            //{"马龙" "迈克尔乔丹" "雷吉米勒" "蒂姆邓肯" "科比布莱恩特" "盖"},请输出最长的字符串
            string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特", "盖" };
            //对比在数组当中找出最大的数字
            string longest = IsLongest(names);
            Console.WriteLine(longest);
            longest = GetLongest(names);
            Console.WriteLine(longest);
            Console.ReadKey(true);
        }
        /// <summary>
        /// 给定一个字符串数字，输出其中最长的字符串
        /// </summary>
        /// <param name="strs">输入的参数 字符串数组</param>
        /// <returns>返回最长的字符串</returns>
        public static string IsLongest(string[] strs)
        {
            string name;
            int max = 0;
            int pos = 0;
            for (int j = 0; j < strs.Length; j++)
            {
                name = strs[j];
                if (name.Length > max)
                {
                    max = name.Length;
                    pos = j;
                }
            }
            return strs[pos];
        }
        /// <summary>
        /// 给定一个字符串数字，输出其中最长的字符串
        /// </summary>
        /// <param name="s">输入的参数 字符串数组</param>
        /// <returns>返回最长的string型字符串</returns>
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }
    }
}
