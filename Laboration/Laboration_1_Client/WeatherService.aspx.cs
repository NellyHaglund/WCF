using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Laboration_1_Client.AddThreeNumbersService;
using Laboration_1_Client.AddTwoNumbersService;
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

        protected void AddTwoNumbersResult_button_Click(object sender, EventArgs e)
        {
            var client = new AddTwoNumbersServiceSoapClient();
            AddTwoNumbersLabelResult.Text = client.AddTwoNumbers(inputX_2.Text, inputY_2.Text);
        }

        protected void AddThreeNumbersButton_Click(object sender, EventArgs e)
        {
          var client = new AddThreeNumbersServiceSoapClient();
            AddThreeNumbersLabelResult.Text = client.AddThreeNumbers(inputX_3.Text, inputY_3.Text, inputZ_3.Text);
        }
    }
}