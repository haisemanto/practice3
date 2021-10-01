using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_分割字符串数组
{
    class Program
    {
        static void Main(string[] args)
        //以“ | ”分割字符串数组并输出 如“梅西|马云|赵信”
        //注意，最后一个并没有|分割
        {
            string[] names = { "梅西", "马云", "赵信", "盖伦" };
            string name = "";
            Test(names, ref name);
            Console.WriteLine(name);
            Console.ReadKey(true);

        }
        public static void Test(string[] s, ref string name)
        {
            for (int i = 0; i < s.Length; i++)
            {
                name += s[i] + "|";
                if (i == s.Length - 1)
                {
                    name += "\b";//利用退格键转义字符来使最后一个字符后面不会输出分隔符
                }

            }
        }
    }
}
