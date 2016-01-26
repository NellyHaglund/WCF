using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShipperClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getShipperButton_Click(object sender, EventArgs e)
        {
            var host = new ShipperServiceClient();
            var shipper = host.GetShipperById(int.Parse(TextBoxShipperCode.Text));

            TextBoxCompanyName.Text = shipper.CompanyName;
            TextBoxPhone.Text = shipper.Phone;
            TextBoxShipperId.Text = shipper.ShipperID.ToString();
        }

        protected void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            var host = new ShipperServiceClient();

        }
    }
}