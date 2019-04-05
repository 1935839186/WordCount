using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Wordcount
    {
         string Read();
        void Countzifu(string All);//统计字符数
        void Countline();
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
        }
    }
}
