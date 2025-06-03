using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sprint_Task_11._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            string[] wd = words.Split(' ');

            for (int i = 0; i < wd.Length; i++)
            {
                Console.WriteLine($"слово {i + 1}: {wd[i]}");
            }
        }
    }
}
