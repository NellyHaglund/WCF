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
        int CalculateBirthDateIntoYears(DateTime date);
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

            var timeSpan = DateTime.Now - date;
            var modulo = (timeSpan.Days % 1000);
            var result = 1000 - modulo;
            var yearToTurnEven1000 = DateTime.Now.AddDays(result).Year;  
            var dateToTurnEven1000 = new DateTime(yearToTurnEven1000, date.Month, date.Day);
            return $"{dateToTurnEven1000.ToShortDateString()} fyller du jämnt 1000-tal";
        }

        public int CalculateBirthDateIntoYears(DateTime date)
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