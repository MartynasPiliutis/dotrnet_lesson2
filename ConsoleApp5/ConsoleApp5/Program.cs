using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string schoolName;
            string courseName;
            double studQuant;

            int startDateYear;
            int startDateMonth;
            int startDateDay;

            int endDateYear;
            int endDateMonth;
            int endDateDay;



            
            DateTime dateToday = DateTime.Today;           
            Console.Write("Iveskite mokylos pavadinima: ");
            schoolName = Console.ReadLine();
            Console.Write("Iveskite kurso pavadinima: ");
            courseName = Console.ReadLine();
            Console.Write("Iveskite studentu kieki: ");
            studQuant = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ivekite kursu pradzios metus: ");
            startDateYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivekite kursu pradzios menesi: ");
            startDateMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivekite kursu pradzios diena: ");
            startDateDay = Convert.ToInt32(Console.ReadLine());
            DateTime startDate = new DateTime(startDateYear, startDateMonth, startDateDay);
            Console.WriteLine(startDate);

            Console.WriteLine("Ivekite kursu pabaigos metus: ");
            endDateYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivekite kursu pabaigos menesi: ");
            endDateMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ivekite kursu pabaigos diena: ");
            endDateDay = Convert.ToInt32(Console.ReadLine());
            DateTime endDate = new DateTime(endDateYear, endDateMonth, endDateDay);
            Console.WriteLine(endDate);


            String diffDays = (endDate - startDate).TotalDays.ToString();
            Console.WriteLine(diffDays);
            Console.WriteLine(Convert.ToInt32(diffDays)/7);


            Console.WriteLine("Mokyklos pavadinimas: {0}", schoolName);
            Console.WriteLine("Kurso pavadinimas: {0}", courseName);
            Console.WriteLine("Studentu kiekis: {0}", studQuant);
            Console.WriteLine("Siandien yra {0}", dateToday.ToLongDateString());
            Console.ReadLine();


        }
    }
}
