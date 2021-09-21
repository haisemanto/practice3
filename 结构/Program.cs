using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
    
{
    public struct Person//定义一个结构,来存储每个人的信息
    {
        public string _name;
        public int _age;
        public Gender _gender;
        public int _grade;//给每个申明前都加上public 让他们的申明使得整个Main函数也能用 
        //在给字段起名字的时候，要区别变量和字段，规范上，要求我们给字段前加上下划线。
    }
    public enum Gender
    {
        男,
        女
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////xx大学管理系统
            ////需要存储 姓名，性别，年龄，系别，年级
            //string zsName = "张三";
            //int zsAge = 21;
            //char zsGender = '男';
            //int zsGrade = 3;
            ////为了张三一个人就声明了四个变量
            Person zsPerson;
            zsPerson._age = 21;
            zsPerson._name = "张三";
            zsPerson._gender = Gender.男;
            zsPerson._grade = 3;

            Person lsPerson;
            lsPerson._grade = 2;
            lsPerson._age = 24;
            lsPerson._name = "李四";
            lsPerson._gender =Gender.女;
            Console.WriteLine(zsPerson._name);
            Console.WriteLine(lsPerson._name);
            Console.ReadKey(true);



        }
    }
}
