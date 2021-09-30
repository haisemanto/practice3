using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStory();//但是总得有个条件来跳出这个死循环
            //TellStory2(0);//我的方法

            Console.ReadKey(true);

        }

        //如何停止递归 
        //以下为老师讲的方法
        public static int i = 0;//定义一个全局变量,作用域是整个的类
        public static void TellStory()
        {


            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            i++;
            if (i >= 10)
            {
                return;//此处通过调试发现，return跳了十次，说明递归进入了十次递归的方法，故在return的时候要跳十次return
                //相当于进了一个房间，房间里有个门，最终进入了十次、
                //return的时候，也需要一个一个门的出来。
            }
            TellStory();
        }
        // //如何停止递归 
        //以下是我个人的方法 在传参上做更改 将第一次运行后的i作为参数传递给下一次递归
        public static void TellStory2(int i)
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            i++;
            if (i >= 10)
            {
                return;
            }
            TellStory2(i);
        }
    }
}
