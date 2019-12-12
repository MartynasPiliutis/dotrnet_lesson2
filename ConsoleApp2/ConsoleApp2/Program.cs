using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            Console.Write("Iveskite pirmaji skaiciu: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antraji skaiciu: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Skaiciu suma yra: {0}", num1 + num2);
            Console.WriteLine("Skaiciu atimtis yra: {0}", num1 - num2);
            Console.WriteLine("Skaiciu daugyba yra: {0}", num1 * num2);
            Console.WriteLine("Skaiciu dalyba yra: {0}", num1 / num2);
            Console.ReadLine();
        }
    }
}
