using System.Configuration;
using System.Data.SqlClient;

namespace NorthwndService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;

        public Employee GetEmployeeById(int id)
        {
            var queryString =
                "SELECT EmployeeID, FirstName, LastName, Title, Country FROM Employees WHERE EmployeeID =" + id;
            var employee = new Employee();
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employee.EmployeeID = (int) reader["EmployeeID"];
                    employee.FirstName = (string) reader["FirstName"];
                    employee.LastName = (string) reader["LastName"];
                    employee.Title = (string) reader["Title"];
                    employee.Country = (string) reader["Country"];
                }
                connection.Close();
            }
            return employee;
        }

        public void SaveEmployee(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.Parameters.AddWithValue("@employeeID", employee.EmployeeID);
                    command.Parameters.AddWithValue("@firstname", employee.FirstName);
                    command.Parameters.AddWithValue("@lastname", employee.LastName);
                    command.Parameters.AddWithValue("@title", employee.Title);
                    command.Parameters.AddWithValue("@country", employee.Country);

                    command.CommandText =
                        "UPDATE Employees SET FirstName = @firstname, LastName = @lastname, Title = @title, Country = @country WHERE EmployeeID = @employeeId";

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}