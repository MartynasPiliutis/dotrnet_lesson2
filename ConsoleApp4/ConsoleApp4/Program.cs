using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName;
            string courseName;
            double studQuant;
            DateTime dateToday = DateTime.Today;
            Console.Write("Iveskite mokylos pavadinima: ");
            schoolName = Console.ReadLine();
            Console.Write("Iveskite kurso pavadinima: ");
            courseName = Console.ReadLine();
            Console.Write("Iveskite studentu kieki: ");
            studQuant = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Mokyklos pavadinimas: {0}", schoolName);
            Console.WriteLine("Kurso pavadinimas: {0}", courseName);
            Console.WriteLine("Studentu kiekis: {0}", studQuant);
            Console.WriteLine("Siandien yra {0}", dateToday.ToLongDateString());
            Console.ReadLine();
        }
    }
}
