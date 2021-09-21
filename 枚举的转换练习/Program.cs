using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举的转换练习
{
    public enum QQState
    {
        OnLine=1,//因为用户从1开始填，所以此处要令初始值为1
        OffLine,
        Leave,
        Qme,
        Busy
    }

    class Program
    {
        static void Main(string[] args)
        {
            //提示用户选择一个在线状态，我们接收，并将用户的输入转换成枚举类型。再次打印到控制台中
            Console.WriteLine("请输入数字选择您的在线状态" +
                "1--OnLine 2--OffLine 3--Leave 4--Qme 5--Busy\t");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQState state = (QQState)Enum.Parse(typeof(QQState), input);
                    //先输入要转换的枚举类型，然后调用Enum.Parse
                    //在Parse后面的空格中输入typeof拿到QQState 然后,输入要转换的数据 
                    //最后在前边声明一个枚举类型来接收他
                    //将string类型转换为枚举类型
                    Console.WriteLine("您选择的在线状态是{0}", state);
                    Console.ReadKey(true);
                    break;
                case "2": 
                    QQState state1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", state1);
                    Console.ReadKey(true);
                    break;
                case "3":
                    QQState state2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", state2);
                    Console.ReadKey(true);
                    break;
                case "4":
                    QQState state3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", state3);
                    Console.ReadKey(true);
                    break;
                case "5":
                    QQState state4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", state4);
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}
