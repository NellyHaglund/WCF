using System;
using System.ServiceModel;

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
        int CalculateAgeIntoDays(DateTime date);
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
            var bmi = weight/(height*height);
            return bmi;
        }

        public string AmIStrong(string input)
        {
            throw new NotImplementedException();
        }

        public string CalculateNext1000Days(DateTime date)
        {
            throw new NotImplementedException();
        }

        public int CalculateAgeIntoDays(DateTime date)
        {
            var yourDate = date.Year;
            var today = DateTime.Now.Year;
            return today - yourDate;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}