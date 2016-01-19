using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecutbildning.Next1000DaysForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {       
            var birth = new DateTime(int.Parse(textBoxYear.Text), int.Parse(textBoxMonth.Text),
                int.Parse(textBoxDay.Text));

            var host = new Next1000DaysCalculatorClient();
            labelResult.Text = host.CalculateNext1000Days(birth);
        }
    }
}
