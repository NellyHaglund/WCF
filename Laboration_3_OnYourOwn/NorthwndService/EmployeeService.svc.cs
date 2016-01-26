using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace NorthwndService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["myDb"].ConnectionString;
        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
