using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Ecutbildning.DateString
{
    [ServiceContract(Namespace = "http://Ecutbildning.DateString")]

    public interface IDateAsString
    {
        [OperationContract]
        string ReturnDateAsString(string input);
    }

    public class DateAsStringService : IDateAsString
    {
        public string ReturnDateAsString(string input)
        {
            Console.WriteLine($"Mottaget: {input}");
            return input == "2016" ? input : "Not a date";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/Ecutbildning.DateString");

            ServiceHost selfServiceHost = new ServiceHost(typeof(DateAsStringService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof(IDateAsString), //Contract
                    new WSHttpBinding(), //Binding
                    "DateAsStringService"); //Address

                //Metadata för att kunna hitta services via WSDL-dokument
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true; //metadata blir tillgängligt för klienten
                selfServiceHost.Description.Behaviors.Add(smb);

                //Öppnar tjänsten
                selfServiceHost.Open();

                //Håller den vid liv
                Console.WriteLine($"Service is ready at {baseAddress}");
                Console.WriteLine($"Press <Enter> to stop the service");

                //Stänger
                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine($"Ett kommunikationsfel har inträffat - {ex.Message}");

                //Avbryter och stänger ned
                selfServiceHost.Abort();

                //Låter arbete som inte är färdigt avslutas innan det stängs ned
                //selfServiceHost.Close();
                Console.ReadLine();
            }
        }
    }
}
