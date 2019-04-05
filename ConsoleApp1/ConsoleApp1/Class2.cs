using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class WCount:Wordcount
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
        public void CountWord(string All)
        {
            int p = 0;
            string[] words = All.Split(
                new char[] { ' ', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);//按照文件中所有空格，换行等，将文件分离为单个单词放进一个数组
            string[] ALL1 = new string[10000];
            for (int i = 0; i < words.Length; i++)
            {
                string str = words[i].ToString();
                string str0 = words[i].ToString();//保留初值
                string strup = str0.ToLower();
                int c = 0;
                if (words[i].Length >= 4)
                {
                    for (int b = 0; b < 4; b++)
                    {
                        string str1 = str.Substring(0, 1);
                        str = str.Remove(0, 1);
                        char ch = Convert.ToChar(str1);
                        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                        {
                            c++;
                        }
                    }
                    if (c == 4)
                    {
                        ALL1[p] = strup;
                        p++;
                    }
                }
            }
            Console.WriteLine("单词总数为：" + p);
            Console.WriteLine("出现最多的10个单词为");
            int a = 0;
            foreach (var kv in ALL1.GroupBy(x => x).OrderByDescending(x => x.Count()))
            {
                if (kv.Key != null)
                {
                    Console.WriteLine("{0}:{1}", kv.Key, kv.Count());
                    a++;
                }
                if (a == 10)
                    break;
            }
        }
    }
}

