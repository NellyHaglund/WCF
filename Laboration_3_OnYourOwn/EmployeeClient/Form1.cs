using System;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using EmployeeClient.EmployeeService;

namespace EmployeeClient
{
    public partial class Form1 : Form
    {
        private EmployeeServiceClient host;

        public Form1()
        {
            InitializeComponent();
            host = new EmployeeServiceClient();
        }

        private void buttonGetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputWhenGetButtonIsPressed()) return;
                if (host.State == CommunicationState.Faulted)
                {
                    host = new EmployeeServiceClient();
                }

                var employee = host.GetEmployeeById(int.Parse(textBoxEmployeeCode.Text));
                textBoxId.Text = employee.EmployeeID.ToString();
                textBoxFirstname.Text = employee.FirstName;
                textBoxLastName.Text = employee.LastName;
                textBoxTitle.Text = employee.Title;
                textBoxContry.Text = employee.Country;
            }
            catch (FaultException<SqlException> exception)
            {
                MessageBox.Show(exception.Detail.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool ValidateInputWhenGetButtonIsPressed()
        {
            var result = 0;
            int.TryParse(textBoxEmployeeCode.Text, out result);
            if (result == 0)
            {
                MessageBox.Show("Enter valid employee ID! Only digits..");
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputWhenSaveButtonIsPressed()) return;
                if (host.State == CommunicationState.Faulted)
                {
                    host = new EmployeeServiceClient();
                }

                var employee = new Employee
                {
                    EmployeeID = int.Parse(textBoxId.Text),
                    FirstName = textBoxFirstname.Text,
                    LastName = textBoxLastName.Text,
                    Title = textBoxTitle.Text,
                    Country = textBoxContry.Text
                };

                host.SaveEmployee(employee);
                MessageBox.Show("Changes Saved");
            }
            catch (FaultException<SqlException> exception)
            {
                MessageBox.Show(exception.Detail.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public bool ValidateInputWhenSaveButtonIsPressed()
        {
            var message = "";
            var result = 0;
            int.TryParse(textBoxId.Text, out result);
            if (result == 0)
            {
                message += "Enter valid employee ID! Only digits..\r";
            }
            if (textBoxFirstname.Text.Trim().Length < 2 || textBoxFirstname.Text.Any(char.IsDigit))
            {
                message += "Firstname must be at least two characters, and cannot contain digits!\r";
            }

            if (textBoxLastName.Text.Trim().Length < 2 || textBoxLastName.Text.Any(char.IsDigit))
            {
                message += "Lastname must be at least two characters, and cannot contain digits!\r";
            }
            if (textBoxTitle.Text.Any(char.IsDigit))
            {
                message += "Title cannot contain digits!\r";
            }
            if (textBoxContry.Text.Any(char.IsDigit))
            {
                message += "Country cannot contain digits!\r";
            }
            if (message == "") return true;
            MessageBox.Show(message);
            return false;
        }
    }
}