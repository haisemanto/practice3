using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//1.在方法中立即返回要返回的值
                        //2.立即结束本次方法

            {
                Console.WriteLine("Hello World");
                //break;
                return;//立即结束本次方法
            }
            Console.WriteLine("Hello .Net");
            Console.ReadKey();

        }
    }
}
