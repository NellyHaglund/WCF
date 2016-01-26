using System;
using System.Data.SqlClient;
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
            catch (FaultException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
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
                labelResult.Text = "Changes Saved";
            }
            catch (FaultException<SqlException> exception)
            {
                MessageBox.Show(exception.Detail.Message);
            }
            catch (FaultException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}