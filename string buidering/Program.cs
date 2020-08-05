using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_buidering
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder();           
            //创建计时器
            Stopwatch sp = new Stopwatch();
            //记下开始时间
            sp.Start();
            for (int i = 0; i < 100000; i++)
            {
                str += i;
               
            }
            //停止时间
            sp.Stop();
            //显示耗时
            Console.WriteLine(sp.Elapsed);
            Console.ReadKey();






        }
    }
}
