using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举练习
{public enum Seaons
    {
        春,
        夏,
        秋,
        冬
    }
    public enum QQState
    {
        OnLine,
        OffLine,
        Leave,
        Busy,
        Qme
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Seaons s = Seaons.春;
            //Console.WriteLine(s);
            //Console.ReadKey(true);

            QQState condition = QQState.OnLine;
            Console.WriteLine(condition);
            Console.ReadKey(true);


        }
    }
}
