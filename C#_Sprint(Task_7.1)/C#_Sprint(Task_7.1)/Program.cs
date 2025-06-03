using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sprint_Task_7._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Розрахунки: ");

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}
