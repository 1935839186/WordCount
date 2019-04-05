using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Wordcount
    {
         string Read();//打开文件
        void Countzifu(string All);//统计字符数
        void Countline();//统计文件有效行
        void CountWord(string All);//统计单词及写入文件及词频及用户自定义
        void Countwordgroup(string All);//统计词组
    }
    class Program
    {
        static void Main(string[] args)
        {
            string All;
            WCount B = new WCount();
            All =B.Read();
           Console.WriteLine(All);
            B.Countzifu(All);
            Console.WriteLine("-----");
            B.Countline();
           Console.WriteLine("-----");
            B.CountWord(All);
            Console.WriteLine("-----");
            B.Countwordgroup(All);

        }
    }
}
