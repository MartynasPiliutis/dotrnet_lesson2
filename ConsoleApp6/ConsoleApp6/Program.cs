using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Iveskite skaiciu: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.ReadLine();

            double numA=1;
            double numB=15;
            double numBuff;

            Console.WriteLine("A = {0} B = {1}", numA, numB);

            numBuff = numA;
            numA = numB;
            numB = numBuff;

            Console.WriteLine("A = {0} B = {1}", numA, numB);
            Console.ReadLine();

            double num1;
            double num2;
            Console.Write("Iveskite pirma skaiciu: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1==num2);
            Console.ReadLine();

            double num3;
            double num4;
            Console.Write("Iveskite pirma skaiciu: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} +1 lygu {1}", num3++, num3);
            Console.WriteLine("{0} -1 lygu {1}", num4--, num4);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.ReadLine();

            double rectangleHeight;
            double rectangleWidth;

            Console.Write("Iveskite staciakampio auksti: ");
            rectangleHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite staciakampio ploti: ");
            rectangleWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Staciakampio plotas yra {0}", rectangleHeight*rectangleWidth);
            Console.ReadLine();

            string text = "";
            Console.Write("Iveskite teksta: ");
            text = Console.ReadLine();
            Console.WriteLine("Eilute tuscia -> {0}", (text == string.Empty));
            Console.ReadLine();

            double number;
            Console.Write("Iveskite skaiciu: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} <= 0 -> {1}", number, (number <= 0));
            Console.ReadLine();

            string name = "";
            string lastName = "";
            Console.Write("Iveskite varda: ");
            name = Console.ReadLine();
            Console.Write("Iveskite pavarde: ");
            lastName = Console.ReadLine();
            Console.WriteLine(name + " " + lastName);
            Console.ReadLine();
        }
    }
}
