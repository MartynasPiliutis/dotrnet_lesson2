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
        }
    }
}
