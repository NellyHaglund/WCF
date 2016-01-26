﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.

namespace NorthwndService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployeeById(int id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]

        public string Firstname { get; set; }
        [DataMember]

        public string Lastname { get; set; }
        [DataMember]

        public string Title { get; set; }
        [DataMember]

        public string Country { get; set; }
    }
}
