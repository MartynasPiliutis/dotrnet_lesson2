using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            Console.Write("Iveskite pirmaji skaiciu: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antraji skaiciu: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite treciaji skaiciu: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ivestu skaiciu vidurkis yra: {0}", (num1+num2+num3)/3);
            Console.ReadLine();
        }
    }
}
