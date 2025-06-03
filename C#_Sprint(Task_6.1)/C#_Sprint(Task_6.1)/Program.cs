using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sprint_Task_6._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть свій вік: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Користувач повнолітній");
            }
            else
            {
                Console.WriteLine("Користувач неповнолітній");
            }
        }
    }
}
