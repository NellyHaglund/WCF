using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecutbildning.HobbyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            var host = new HobbyClient();
            var kilos = textBoxKilo.Text;
            var gender = textBoxGender.Text;
            var input = kilos + ";" + gender;
            labelResult.Text = host.AmIStrong(input);
            
        }
    }
}
