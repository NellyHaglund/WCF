using System;
using System.Web.UI;
using NorthwindService;

namespace ShipperClient
{
    public partial class Default : Page
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
            
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            var host = new ShipperServiceClient();
            var shipper = new Shipper
            {
                ShipperID = int.Parse(TextBoxShipperId.Text),
                CompanyName = TextBoxCompanyName.Text,
                Phone = TextBoxPhone.Text
            };
            host.SaveShipper(shipper);
        }
    }
}