using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举和int以及string之间的转换
{
    public enum QQState//声明一个枚举
    {
        OnLine,
        OffLine,
        Busy,
        Qme,
        Leave
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强制转换为int型
            //QQState state = QQState.OnLine;//枚举类型默认可以和int类型相互转换 枚举类型跟int类型是兼容的
            //int n = (int)state;
            ////Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OnLine);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.Qme);
            //Console.WriteLine((int)QQState.Leave);//输出结果显示 强制转换输出的结果是默认从第一个为0开始  
            #endregion
            #region 将int类型转换为枚举类型
            //int n1 = 3;
            //QQState state = (QQState)n1;//将n1＝3强制转换为QQState，输出所对应的Busy
            ////但若 int n1=8;则还是输出8
            //Console.WriteLine(state); 
            #endregion
            #region 将枚举类型强制转换为string类型
            //int n1 = 10;
            //string s = n1.ToString();//数据类型.ToString()方法能将所有类型的数据转换为string类型

            //QQState state = QQState.Leave;
            //string strSeason = state.ToString();//数据类型.ToString() 表示将这个数据强制转化为string类型
            //Console.WriteLine(strSeason);
            //Console.WriteLine(state.ToString()); 
            #endregion
            string s = "0";//当遇到枚举中没有的值得时候，就会报异常
            //将s转换为枚举类型，如果0是int型，可以直接用强转
            //Convert.ToInt32();
            //int.Parse(s);数据类型.Parse（string） 表示将string数据类型的数据转换为他的32位有符号数
            QQState state = (QQState)Enum.Parse(typeof(QQState), s);//调用Parse方法的目的就是为了让它帮助我们将一个字符串转换为一个枚举类型
                                                                    //这个东西 一般用得很少 用得时候直接查 将string类型转为枚举类型                                                          
            Console.WriteLine(state);
            Console.ReadKey(true);

        }
    }
}
