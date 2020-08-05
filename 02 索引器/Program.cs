using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_索引器
{
    class TempRcord
    {
        //温度数组初始化数组
        public double[] temps = new double[5] { 20.5, 31.4, 15.5, 19.7, 30 };

        //索引器
    public double this[int index]
        {
            get { return temps[index]; }
            set { temps[index] = value; }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TempRcord P = new TempRcord();
            Console.WriteLine(P.temps[0]);
            Console.WriteLine(P.temps[1]);
            Console.WriteLine("==============");

            Console.WriteLine(P[0]);
            Console.WriteLine(P[1]);


            Console.ReadKey();









        }
    }
}
