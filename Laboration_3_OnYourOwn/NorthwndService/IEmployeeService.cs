using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace NorthwndService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        Employee GetEmployeeById(int id);

        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]

        void SaveEmployee(Employee employee);
    }
}
