using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法练习_输入分数_判断等级
{
    class Program
    {
        static void Main(string[] args)
        //95、接受输入后判断其等级并显示出来。判断依据如下:等级={优(90--100分) ;
        //良(80--89分);及格（60-79分）;不及格（0-59分）
        {
            Console.WriteLine("请输入分数");
            int grade = 0;
            bool b = true;
            while (b)
            {
                string grades = Console.ReadLine();
                grade = GetNumber(grades);
                if (grade <= 100 && grade > 0)
                {
                    b = false;
                }
                else
                {
                    Console.WriteLine("输入的分数范围有误,请重新输入。");
                }
            }
            string level = IsLevel(grade);//switch的做法
            //string level = JudgeLevel(grade);//if else的做法
            Console.WriteLine("您输入的分数为{0}\n分数的等级为{1}", grade, level);
            Console.ReadKey();


        }
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;//因为有return的原因，所以前面的while中即使是true也可以跳出该循环
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断等级
        /// </summary>
        /// <param name="grade">传入参数，分数（0-100）</param>
        /// <returns>返回一个字符串表示成绩的等级（优良，及格，不及格）</returns>
        public static string JudgeLevel(int grade)
        {
            string level;
            if (grade >= 90 && grade <= 100)
            {
                level = "优";
                return level;
            }
            else if (grade >= 80 && grade <= 89)
            {
                level = "良";
                return level;
            }
            else if (grade >= 60 && grade <= 79)
            {
                level = "及格";
                return level;
            }
            else
            {
                level = "不及格";
                return level;
            }

        }
        public static string IsLevel(int grade)
        {
            string level = "";

            switch (grade / 10)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    level = "不及格";
                    break;
                case 6:
                case 7:
                    level = "及格";
                    break;
                case 8:
                    level = "良";
                    break;
                case 9:
                case 10:
                    level = "优";
                    break;
            }
            return level;

        }

    }
}
