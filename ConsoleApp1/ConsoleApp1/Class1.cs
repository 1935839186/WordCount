using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class  WordCount
    {
        public string  Read()

        {
            string all="";
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
       
    }
}
