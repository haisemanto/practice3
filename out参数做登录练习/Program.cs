using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out参数做登录练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别的提示用户输入用户名和密码
            //写一个方法来判断用户输入的是否正确
            //返回给用户一个登录的结果
            //并且还要单独的返回给用户名一个登录信息
            //如果用户名错误，除了返回登录结果之外，还要返回一个"用户名错误"
            //密码错误同上


            //返回结果分析
            //账号，密码均对---返回true并且返回登录成功
            //账号密码有一个错误---返回false并且返回 账号或者密码错误
            Console.WriteLine("请输入账号");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            string msg;
            bool b=Program.IsLogin(name, pwd, out msg);
            Console.WriteLine(msg);
            Console.WriteLine(b);
            Console.ReadKey(true);

        }
        /// <summary>
        /// 判断用户输入账号密码是否正确 并返回一个bool型
        /// </summary>
        /// <param name="name">账号</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">返回登录成功与否</param>
        /// <returns></returns>
        public static bool IsLogin(string name, string pwd, out string msg)
        {
            if (name == "admin" && pwd == "888888")
            {
                msg = "登录成功";
                return true;
            }
            else
            {
                msg = "账号或密码错误";
                return false;
            }
        }

    }
}
