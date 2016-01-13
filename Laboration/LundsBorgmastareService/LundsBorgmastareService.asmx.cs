using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LundsBorgmastareService
{
    /// <summary>
    /// Summary description for LundsBorgmastareService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LundsBorgmastareService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReturnMayorForSpecificYear(string year)
        {
            var yearInteger = int.Parse(year);
            var result = "";
            var data =
                File.ReadAllLines(
                    @"C:\Users\NellyHaglund\Documents\Skolan\WCF\Laborationer\WCF_Github\WCF\Laboration\LundsBorgmastareService\LundBorgmastare.txt");
            foreach (var s in data)
            {              
                var split = s.Split(';');
                var years = split[0].Split('-');
                if (yearInteger >= int.Parse(years[0]) && yearInteger <= int.Parse(years[1]))
                {
                    result = $"Mayor in {yearInteger}: {split[1]}({split[0]})";
                    break;

                }
                else
                {
                    result = "No mayor found year " + yearInteger;
                }
            }

            return result;
        }
    }
}
