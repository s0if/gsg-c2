using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int c = 1;c<10 ; c++) 
            {
               int number=int.Parse( Console.ReadLine());
                list.Add(number);
            }
            list.Sort();
            for (int c =0; c < 9; c++)
            {
                if (list[c]!=c+1)
                {
                    Console.WriteLine($"missing : {list[c] - 1}");
                    break;
                }
            }
        }
    }
}
