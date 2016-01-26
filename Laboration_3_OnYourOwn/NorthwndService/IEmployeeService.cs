using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Data;


namespace NorthwndService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        Employee GetEmployeeById(int id);

        [OperationContract]
        [FaultContract(typeof(ApplicationException))]

        void SaveEmployee(Employee employee);
    }
}
