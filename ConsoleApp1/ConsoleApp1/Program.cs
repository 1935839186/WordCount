using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string All;
            WordCount A = new WordCount();
            All=A.Read();
           // Console.WriteLine(All);
            Count B = new Count();
            B.Countzifu(All);
            Console.WriteLine("-----");
           // B.Countline();
           // Console.WriteLine("-----");
            B.Countword(All);
        }
    }
}
