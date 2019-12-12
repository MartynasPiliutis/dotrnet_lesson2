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

            /*if (num1==num2)
            {
                Console.WriteLine("{0} lygu {1}", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} nelygu {1}", num1, num2);
            }*/

            Console.WriteLine(num1==num2);

            Console.ReadLine();

            double num3;
            double num4;
            Console.Write("Iveskite pirma skaiciu: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            num4 = Convert.ToDouble(Console.ReadLine());
            //double num5 = num3++;
            //double num6 = num4--;
            Console.WriteLine("{0} +1 lygu {1}", num3, num3++);
            Console.WriteLine("{0} -1 lygu {1}", num4, num4--);
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

        }
    }
}
