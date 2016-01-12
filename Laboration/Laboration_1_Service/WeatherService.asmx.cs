using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Laboration_1_Service
{
    /// <summary>
    /// Summary description for WeatherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WeatherService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GenerateWeather()
        {
            var random = new Random();
            var weathers = new List<string>() {"Soligt", "Soligt med delvis molnighet", "Regn, en jävla massa regn", "Nu snöar det", "Det är grått ute"};

            return weathers[random.Next(weathers.Count)];
        }
    }
}
