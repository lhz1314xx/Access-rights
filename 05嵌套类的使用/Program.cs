using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05嵌套类的使用
{
    class Container
    {
        protected string name = "Container";//受保护
        void SayHellow()
        {
            Console.WriteLine("Hello Container ");
        }
        //嵌套类
        public class Nested
        {
            //嵌套类的方法
            protected string name = "Nested";
            public void SayHello()
            {
                Container s1 = new Container();
                Console.WriteLine("Container.name={0}", s1.name);
                s1.SayHellow();
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
            Console.ReadKey();
        }
    }
}

