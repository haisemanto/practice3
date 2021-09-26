using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的调用_传参
{
    //观察以下程序 判断输出结果
    //答：会报错
    //static void Main(string[] args)
    //{
    //    int a = 3;
    //    Test();
    //    Console.WriteLine(a);
    //    Console.ReadKey();

    //}
    //public static void Test()
    //{
    //    a = a + 5;//报错的原因是Test()函数得不到调用者Main()函数的值
    //}
}
class Program
{
    public static int _number = 10;//作用域整个program类，所以用来模拟全局变量

    static void Main(string[] args)
    {
        int a = 3;
        //int b = 10;//在别的函数中无法访问,所以在类下定义一个字段来模拟全局变量
        int res=Test(a);//第一种方法 传参
        Console.WriteLine(res);
        Console.ReadKey();
    }
    public static int Test(int a)//第一种方法 传参
    {
        a = a + 5;
        return a;
    }
}
