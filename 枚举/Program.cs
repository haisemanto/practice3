using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{//枚举声明在这里时，每个类（包括所有Main函数）都能用到这个枚举的数据。枚举声明在这里比较好

    public enum Gender//声明了一个枚举
    {
        男,
        女//此处加不加逗号都可以，不加表示这是枚举中的最后一个值
    }
    public enum Seasons
    {
        春=1,
        夏,
        秋,
        冬
    }

    class Program
    {//枚举声明在这里时，整个Main函数都能用到这个枚举
        static void Main(string[] args)
        {
            //为什么会有枚举这个东西
            //xx大学管理系统
            //姓名 性别 年龄 系别 年级
            //性别比较特殊
            //char gender = '男';
            //string strGender = "male";
            //string strGender2 = "纯爷们";
            //用了两种数据类型，存储了相同意思的三个数据
            //当不同的人因为不同的代码风格，编写了同样意思的三种代码时候，整合的时候就容易报错
            //所以用枚举的方法来对这个数据类型进行一个固定，要用的时候直接拿来用就可以了
            //作用：用来规范我们的开发。
            //Gender gender = Gender.男;//枚举中的赋值，只能在最开始的枚举中去选择
            //Console.WriteLine(gender);
            Console.WriteLine("请输入一个季节（数字1234 春夏秋冬）");
            string input = Console.ReadLine();
            Seasons season1 = (Seasons)Enum.Parse(typeof(Seasons), input);
            Seasons season2 = (Seasons)Enum.Parse(typeof(Seasons), input);
            Seasons season3 = (Seasons)Enum.Parse(typeof(Seasons), input);
            Seasons season4 = (Seasons)Enum.Parse(typeof(Seasons), input);
            switch (input)
            {
                case "1":
                    Console.WriteLine("您选择的季节是{0}",season1);
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("您选择的季节是{0}",season2);
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("您选择的季节是{0}",season3);
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("您选择的季节是{0}",season4);
                    Console.ReadKey();
                    break;
            }


            Console.ReadKey(true);


        }
    }
}
