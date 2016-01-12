using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace Laboration_1_punkt_5_Service
{
    /// <summary>
    /// Summary description for NameDay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NameDay : System.Web.Services.WebService
    {

        [WebMethod]
        public string DateOfNameDay(string name)
        {
            var data = File
                .ReadAllLines(@"C:\Users\NellyHaglund\Documents\Skolan\WCF\Laborationer\WCF_Github\WCF\Laboration\Laboration_1_punkt_5_Service\namesAndDays\NameDays.txt");
            var dateList = new Dictionary<string, DateTime>();
            var count = 0;
            foreach (var d in data)
            {
                if (d != "--")
                {
                    var items = d.Split(';');
                    dateList.Add(items[1], new DateTime(DateTime.Now.Year, count, int.Parse(items[0])));
                }
                else
                    count++;
            }
            var result = dateList.FirstOrDefault(x => x.Key == name).Value;
            return result.Year == 0001 ? (name + ": Not Found") : (name + " has nameday at: " + result.ToShortDateString());
        }
    }
}
