using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Laboration_1_Client.WeatherGenerator;

namespace Laboration_1_Client
{
    public partial class WeatherService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void generateWeather_Click(object sender, EventArgs e)
        {
            WeatherGenerator.WeatherServiceSoapClient client = new WeatherServiceSoapClient();
            weatherResult.Text = client.GenerateWeather();
        }
    }
}