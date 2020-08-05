using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_z字符串的操作
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = "abcdefg";
            //Console.WriteLine(s[0]);
            //Console.WriteLine("=============");
            //char[] chs = s.ToCharArray();
            //chs[0] = 's';
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    Console.WriteLine(chs[i]);
            //}
            //分割符使用          
            //string str1 = "2008-8-8";
            //string[] str1s = str1.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",str1s[0],str1s[1],str1s[2]);

            //截取获取字符串
            //string str = "一拳超人";
            //string s1 = str.Substring(2);
            //string s2 = str.Substring(0, 2);//从0个字符开始截取截取2个字符
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //连接字符串
            //string str = string.Format("{0}年{1}月{2}日", 2008, 8, 8);
            //Console.WriteLine(str);
            //string s1 = "我爱";
            //string s2 = "中国";
            //string s3 = string.Concat(s1, s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s1+s2);
            //去空格
            //string str = " abc ";
            //Console.WriteLine(str);
            //string str1 = str.Trim();//去除前后的空格
            //Console.WriteLine(str1);
            //string str2 = str.TrimEnd();//去除后空格
            //Console.WriteLine(str2);
            //string str3 = str.TrimStart();//去除前空格
            //Console.WriteLine(str3);

            //判断是否为空
            //string str = "";//判断null和内存的空间没有内容
            //if(string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("为空");
            //}
            //else
            //{
            //    Console.WriteLine("不为空");
            //}
            //Join连接字符
            //string[] name = { "罗老师", "蔡老师" };
            //string strNew = string.Join("", name);
            //Console.WriteLine(strNew);

            ////
            //string str = "abcdefgdfgd";
            //int index1 = str.IndexOf('d');
            //int index2 = str.IndexOf('d', index1 + 1);
            //Console.WriteLine(index1);
            //Console.WriteLine(index2);           
            //Console.WriteLine(str.Substring(index1, (index2 - index1) + 1));

            //输出一个字符串，找到所有的e的位置
            //string str1 = "abcdefgdfgdedddedde";
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    if (str1[i] == 'e')
            //    {
            //        Console.WriteLine("字符串第{0}位是e",i+1);
            //        Console.WriteLine(str1[i]);
            //    }
            //}
            //int index1 = str1.IndexOf("e");
            //int count = 0;//计算出现个数
            //while (index1 != -1)
            //{
            //    count++;
            //    index1 = str1.IndexOf("e", index1 + 1);
            //    if (index1 == -1)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("第{0}出现e", count);

            //字符串是字符的只读数组;
            string s = "abcdefgh";
            //将字符串转换为char[]
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将char[]转换为字符串
            s = new string(chs);
            Console.WriteLine(s);
            //s.ToUpper;
            //s.ToLower;
            bool b=s.Equals("Abcdefgh", StringComparer.OrdinalIgnoreCase);






            Console.ReadKey();
        }
    }
}
