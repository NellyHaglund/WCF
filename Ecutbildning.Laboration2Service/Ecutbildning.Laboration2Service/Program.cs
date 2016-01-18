using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ecutbildning.Laboration2Service
{
    [ServiceContract(Namespace = "http://Ecutbildning.Laboration2Service")]
    public interface IBMICalculator
    {
        float CalculateBMI(float weight, float height);
    }

    public class BMICalculatorService : IBMICalculator
    {
        public float CalculateBMI(float weight, float height)
        {
            return weight/(weight*height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}
