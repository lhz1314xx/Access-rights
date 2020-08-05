using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03嵌套类
{
    class Container
    {
        //嵌套类
        public class Nested
        {
            //嵌套类的方法

            public void SayHello()
            {
                Console.WriteLine("Hello i am a nested class");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Container.Nested a = new Container.Nested();
            a.SayHello();
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
