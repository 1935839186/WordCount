using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Count
    {
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
        public void Countword(string All)//统计单词数
        {
            //string str = All.Replace("\n","").Replace("\r","");
            string str = All;
            string[] sword = str.Split(new char[4] { ',', ' ','.' ,'\n'});
            int i ,n;
            int j = 0;
            int m = 0;
            for (i = 0; i < sword.Length; i++)
            {
                char[] cc = sword[i].ToCharArray();
                for (n=0;n<cc.Length;n++)
                {
                    //Console.WriteLine(cc[n]);
                   if ((cc[n] >= 65 && cc[n] <= 90) || (cc[n] >= 97 && cc[n] <= 122))
                    {
                        m++;
                   }
                    if (sword[i].Length >= 4&&m==4)
                    {
                        Console.WriteLine(sword[i]);
                        j++;
                   }
                }
            }
                
           Console.WriteLine("单词个数为：{0}",j);
        }
    }
}
