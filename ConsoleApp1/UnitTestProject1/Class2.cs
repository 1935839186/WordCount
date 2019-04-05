using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Count:IWORDcount
    {
        public string Read()//打开文件
        {
            string all = "";
            while (all == "")
            {
                Console.Write("请输入想要统计的文件:");
                string fx = Console.ReadLine();
                if (File.Exists(fx))
                {
                    string fn = @fx;
                    //string fn = @"E:\text.txt";
                    all = File.ReadAllText(fn, Encoding.UTF8);
                    return all;
                }
                else
                {
                    Console.WriteLine("文件不存在");
                }
            }
            return all;
        }
        public void Countzifu(string All)//统计字符数
        {
            string A = All;
            Console.WriteLine("文件中的字符数是：{0}",A.Length);
        }
        public void Countline()//统计有效行
        {
            int i = 0;
            Console.Write("请输入想要统计行的文件:");
            string fx = Console.ReadLine();
            if (File.Exists(fx))
            {
                string fn = @fx;
                StreamReader fs = new StreamReader(fn);
                string line;
                while ((line = fs.ReadLine()) != null)
                {
                    i++;
                }
            }
            Console.WriteLine("文件的有效行数为：{0}",i);
        }
    }
}
