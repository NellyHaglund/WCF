using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Laboration_1_Client.AddThreeNumbersService;
using Laboration_1_Client.AddTwoNumbersService;
using Laboration_1_Client.LundsMayorService;
using Laboration_1_Client.NameDayService;
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
            var client = new WeatherServiceSoapClient();
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

        protected void SubtractTwoNumbersButton_Click(object sender, EventArgs e)
        {
            var client = new Laboration_1_Punkt_4_Service.SubtractTwoNumbersService();
            SubtractTwoNumbersResult.Text = client.SubtractTwoNumbers(inputX_4.Text, inputY_4.Text);
        }

        protected void nameDay_button_Click(object sender, EventArgs e)
        {
            var client = new NameDaySoapClient();
            nameDay_result.Text = client.DateOfNameDay(input_name.Text);
        }

        protected void mayor_button_Click(object sender, EventArgs e)
        {
            var client = new LundsBorgmastareServiceSoapClient();
            mayor_result.Text = client.ReturnMayorForSpecificYear(input_year.Text);
        }
    }
}