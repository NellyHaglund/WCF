using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Laboration_1_Punkt_2_Service
{
    /// <summary>
    /// Summary description for AddTwoNumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddTwoNumbersService : System.Web.Services.WebService
    {

        [WebMethod]
        public float AddTwoNumbers(float x, float y)
        {
            return x + y;
        }
    }
}
