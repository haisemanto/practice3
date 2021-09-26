using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法函数练习
{
    class Program
    {
        /// <summary>
        /// 正常玩游戏
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
            Console.WriteLine("马里奥一直走");
        }
        /// <summary>
        /// 无敌
        /// </summary>
        public static void WuDi()
        {
            Console.WriteLine("吃到了一个无底星");
            Console.WriteLine("屏幕开始闪烁");
            Console.WriteLine("播放无敌音乐");
        }
        static void Main(string[] args)
        {
            Program.PlayGame();
            Program.WuDi();
            Console.ReadKey();

        }
    }
}
