using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构_练习
{
    class Program
    {
        public struct MyColor
        {
            public int _red;
            public int _green;
            public int _blue;
        }
        public struct Person
        {
            public string _name;
            public int _age;
            public Gender _gender;//性别用枚举类型时，此处的char 也要改成Gender
        }
        public enum Gender
        {
            男,
            女
        }

        static void Main(string[] args)
        {
            //定义一个结构叫MyColor,有三个成员，分别定义为int类型的red，green，blue
            //声明一个MyColor类型的变量，并对其成员赋值。使MyColor可以表示成一个红色
            //MyColor mc;
            //mc._red = 255;
            //mc._blue = 0;
            //mc._green = 0;

            //定义一个结构类型Person，有三个成员，分别为姓名，性别，年龄，性别用枚举类型
            //声明两个Person的变量 分别表示为 张三 男 18岁/小兰 女 16岁
            Person zsPerson;
            zsPerson._name = "张三";//给这两个结构的字段赋值
            zsPerson._age = 18;
            zsPerson._gender = Gender.男;
            Person xlPerson;
            xlPerson._name = "小兰";
            xlPerson._age = 16;
            xlPerson._gender = Gender.女;
            //Console.WriteLine(zsPerson._name);
            //Console.WriteLine(zsPerson._gender);
            //Console.WriteLine(zsPerson._age);
            Console.WriteLine("我叫{0}，我今年{1}岁，我是{2}生",zsPerson._name,zsPerson._age,zsPerson._gender);

            //Console.WriteLine(xlPerson._name);
            //Console.WriteLine(xlPerson._gender);
            //Console.WriteLine(xlPerson._age);
            Console.WriteLine("我叫{0}，我今年{1}岁，我是{2}生", xlPerson._name, xlPerson._age, xlPerson._gender);
            Console.ReadKey(true);

        }
    }
}
