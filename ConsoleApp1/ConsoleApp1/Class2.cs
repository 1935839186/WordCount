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
            string str = All;
            string[] sword = str.Split(new char[4] { ',', ' ','.' ,'\n'});
            int i ,n;
            int j = 0;
            int m = 0;
            for (i = 0; i < sword.Length; i++)
            {
                char[] cc = sword[i].ToCharArray();
               // for (n=0;n<4;n++)
               // {
                   // if ((cc[n] >= 65 && cc[n] <= 90) || (cc[n] >= 97 && cc[n] <= 122))
                   //// {
                     //   m++;
                   // }
                    //else continue;             
                //}
                if (sword[i].Length >= 4 && (cc[1] >= 65 && cc[1] <= 90) || (cc[1] >= 97 && cc[1]<= 122)&& (cc[2] >= 65 && cc[2] <= 90) || (cc[2] >= 97 && cc[2] <= 122)&& (cc[3] >= 65 && cc[3] <= 90) || (cc[3] >= 97 && cc[3] <= 122)&& (cc[0] >= 65 && cc[0] <= 90) || (cc[0] >= 97 && cc[0] <= 122))
                {
                    Console.WriteLine(sword[i]);
                    j++;
                }
            }
           Console.WriteLine("单词个数为：{0}",j);
        }
    }
}
