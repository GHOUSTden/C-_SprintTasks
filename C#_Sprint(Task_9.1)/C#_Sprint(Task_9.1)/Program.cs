using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sprint_Task_9._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
