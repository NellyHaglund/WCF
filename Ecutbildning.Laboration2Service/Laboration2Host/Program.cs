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

            ServiceHost selfServiceHost = new ServiceHost(typeof(LaborationService), baseAddress);

            try
            {
                var binding = new WSHttpBinding();
                selfServiceHost.AddServiceEndpoint(typeof(IBMICalculator), binding, "LaborationService");
                selfServiceHost.AddServiceEndpoint(typeof(IHobby), binding, "LaborationService");
                selfServiceHost.AddServiceEndpoint(typeof(INext1000DaysCalculator), binding, "LaborationService");
                selfServiceHost.AddServiceEndpoint(typeof(IYearCalculator), binding, "LaborationService");

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
