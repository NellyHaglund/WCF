using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EcUtbildning.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                DateAsStringClient host = new DateAsStringClient();
                Console.WriteLine("Skriv datumet 2016");
                var date = Console.ReadLine();
                Console.WriteLine(host.ReturnDateAsString(date));
                Console.ReadLine(); 
            }
        }
    }
}
