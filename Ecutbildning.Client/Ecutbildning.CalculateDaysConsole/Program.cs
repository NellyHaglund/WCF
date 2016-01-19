using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecutbildning.CalculateDaysConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            YearCalculatorClient host = new YearCalculatorClient();
            Console.WriteLine("Insert year");
            var year = Console.ReadLine();
            Console.WriteLine("Insert month");
            var month = Console.ReadLine();
            Console.WriteLine("Insert day");
            var day = Console.ReadLine();
            var birth = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            Console.WriteLine(host.CalculateAgeIntoDays(birth));

            Console.ReadLine();
        }
    }
}
