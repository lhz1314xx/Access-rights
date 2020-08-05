using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十天课程//命名空间名
{
    class Person//默认属于internal 访问权限，程序集当中，
    {
        public const int a = 65;
        //只限于当前程序集或当前类
        internal string NickName;
        //当前了或派生类
        protected bool Ismerried;

        //仅限于当前类访问
        private int age;

        //如果不写默认时私有
        string name;

        //访问不受限
        public static void Say()
        {
            Console.WriteLine("Hello World");
        }

        //只能在当前类访问
        private void Methold()
        {
            //可以访问当前类的所有成员字段 / 属性 / 方法;
        }
    }
    public class Say
    {
        public static void Hi()
        {
            Console.WriteLine("HI");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {



        }
    }
}
