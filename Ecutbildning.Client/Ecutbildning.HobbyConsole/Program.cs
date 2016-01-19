using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecutbildning.HobbyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fyll i hur mycket du tar i bänkpress (kg)");
            var kilo = Console.ReadLine();
            Console.WriteLine("Är du kvinna eller man?");
            var gender = Console.ReadLine();
            var input = kilo + ";" + gender;
            var host = new HobbyClient();
            Console.WriteLine(host.AmIStrong(input));
            Console.ReadLine();
        }
    }
}
