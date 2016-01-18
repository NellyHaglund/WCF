using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Ecutbildning.Laboration2Service;

namespace Laboration2Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/Ecutbildning.Laboration2Service");

            ServiceHost selfServiceHost = new ServiceHost(typeof(LaborationService));

            try
            {
                selfServiceHost.AddServiceEndpoint(typeof(IBMICalculator), new WSHttpBinding(), "LaborationService");
                selfServiceHost.AddServiceEndpoint(typeof(IHobby), new WSHttpBinding(), "LaborationService");
                selfServiceHost.AddServiceEndpoint(typeof(INext1000DaysCalculator), new WSHttpBinding(), "LaborationService");
                selfServiceHost.AddServiceEndpoint(typeof(IYearCalculator), new WSHttpBinding(), "LaborationService");

                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior();
                smBehavior.HttpGetEnabled = true;
                selfServiceHost.Description.Behaviors.Add(smBehavior);
                selfServiceHost.Open();

                Console.ReadLine();
            }
            catch (CommunicationException exception)
            {
                selfServiceHost.Abort();
                Console.ReadLine();
            }
        }
    }
}
