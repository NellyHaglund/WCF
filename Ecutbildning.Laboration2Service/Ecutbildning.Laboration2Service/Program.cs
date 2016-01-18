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
        [OperationContract]
        float CalculateBMI(float weight, float height);
    }
    [ServiceContract(Namespace = "http://Ecutbildning.Laboration2Service")]
    public interface IYearCalculator
    {
        [OperationContract]
        float CalculateAgeIntoYears(DateTime date);
    }

    [ServiceContract(Namespace = "http://Ecutbildning.Laboration2Service")]
    public interface INext1000DaysCalculator
    {
        [OperationContract]
        string CalculateNext1000Days(DateTime date);
    }

    [ServiceContract(Namespace = "http://Ecutbildning.Laboration2Service")]
    public interface IHobby
    {
        [OperationContract]
        string AmIStrong(string input);
    }


    public class LaborationService : IBMICalculator, IYearCalculator, INext1000DaysCalculator, IHobby
    {
        public float CalculateBMI(float weight, float height)
        {
            return weight / (weight * height);
        }

        public float CalculateAgeIntoYears(DateTime date)
        {
            throw new NotImplementedException();
        }

        public string CalculateNext1000Days(DateTime date)
        {
            throw new NotImplementedException();
        }

        public string AmIStrong(string input)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
