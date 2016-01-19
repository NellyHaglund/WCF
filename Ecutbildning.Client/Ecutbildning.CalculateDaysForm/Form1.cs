using System;
using System.Windows.Forms;

namespace Ecutbildning.CalculateDaysForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var host = new YearCalculatorClient();
            var birth = new DateTime(int.Parse(textBoxYear.Text), int.Parse(textBoxMonth.Text),
                int.Parse(textBoxDay.Text));

            labelResult.Text += host.CalculateBirthDateIntoYears(birth);
        }
    }
}