using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int YearOfBirth;
            string FirstName;

            var LastName = "Pavardenis";
            decimal Salary = 1999.9m;
            DateTime LastPayDay = DateTime.Today.AddMonths(-1);

            YearOfBirth = 1990;
            FirstName = "Vardenis";

            Console.WriteLine("Vardas, Pavarde: {0} {1}", FirstName, LastName);
            Console.WriteLine("Gimimo metai: {0}", YearOfBirth);
            Console.WriteLine("Pajamos: {0}", Salary);
            Console.WriteLine("Paskutini karta ismoketa alga: {0}", LastPayDay.ToLongDateString());
            Console.ReadLine();
        }
    }
}
