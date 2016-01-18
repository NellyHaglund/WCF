using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;


namespace Ecutbildning.Color
{
    [ServiceContract(Namespace = "http://Ecutbildning.Color")]
    public interface IColor
    {
        [OperationContract]
        string IsColor(string color);
    }

    public class ColorService : IColor
    {
        public string IsColor(string color)
        {
            Console.WriteLine($"Mottaget: {color}");
            if (color.ToLower() == "black" || color.ToLower() == "white")
            {
                return "That is no color";
            }
            else
            {
                return "This is a color";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/Ecutbildning.Color");

            ServiceHost selfServiceHost = new ServiceHost(typeof(ColorService), baseAddress);

            try
            {
                selfServiceHost.AddServiceEndpoint
                    (typeof(IColor), //Contract
                    new WSHttpBinding(), //Binding
                    "ColorService"); //Address

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
