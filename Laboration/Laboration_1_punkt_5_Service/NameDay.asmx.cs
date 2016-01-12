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
            var day = new DateTime().Day;
            var month = new DateTime().Month;
            var data = File
                .ReadAllLines(@"C:\Users\NellyHaglund\Documents\Skolan\WCF\Laborationer\WCF_Github\WCF\Laboration\Laboration_1_punkt_5_Service\namesAndDays\NameDays");

            return "";
        }
    }
}
