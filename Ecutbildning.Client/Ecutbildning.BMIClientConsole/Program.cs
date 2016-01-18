using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecutbildning.BMIClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalculatorClient host = new BMICalculatorClient();
            Console.WriteLine("Insert you height: ");
            var height = Console.ReadLine();
            Console.WriteLine("Insert your weight: ");
            var weight = Console.ReadLine();

            Console.WriteLine(host.CalculateBMI(float.Parse(weight), float.Parse(height)));
            Console.ReadLine();
        }
    }
}
