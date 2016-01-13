using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IndiaVicePresidentService
{
    /// <summary>
    /// Summary description for IndiaVicePresidentService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class IndiaVicePresidentService : System.Web.Services.WebService
    {

        [WebMethod]
        public string IndiaVicePresidentGivenYear(string year)
        {
            var yearInteger = int.Parse(year);
            var vicePresidents =
                File.ReadAllLines(
                    @"C:\Users\NellyHaglund\Documents\Skolan\WCF\Laborationer\WCF_Github\WCF\Laboration\IndiaVicePresidentService\IndiaVicePresidents.txt");

            var message = "";

            foreach (var vicePresident in vicePresidents)
            {
                var split = vicePresident.Split(';');
                var name = split[0];
                var years = split[1].Split('-');
                if (yearInteger >= int.Parse(years[0]) && yearInteger <= int.Parse(years[1]))
                {
                    message = $"Vice president in India year {yearInteger}: {name}";
                    break;
                }
                else
                {
                    message = $"No vice president found in year {yearInteger}";
                }

            }
            return message;
        }
    }
}
