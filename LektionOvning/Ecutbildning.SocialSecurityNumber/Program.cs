using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Ecutbildning.SocialSecurityNumber
{
    [ServiceContract(Namespace = "http://Ecutbildning.SocialSecurityNumber")]
    public interface IGender
    {
        [OperationContract]
        string ReturnGender(string socialSecurityNumber);
    }

    public class GenderService : IGender
    {
        public string ReturnGender(string socialSecurityNumber)
        {
            if (socialSecurityNumber[socialSecurityNumber.Length - 1] % 2 == 0)
            {
                return "Man";
            }
            else
            {
                return "Woman";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/Ecutbildning.SocialSecurityNumber");

            ServiceHost selfServiceHost = new ServiceHost(typeof(GenderService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof(IGender), //Contract
                    new WSHttpBinding(), //Binding
                    "GenderService"); //Address

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
