using System.Configuration;
using System.Data.SqlClient;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    public class ShipperService : IShipperService
    {
        private readonly string _connectionstring = ConfigurationManager.
            ConnectionStrings["NORTHWND"].ConnectionString;

        public Shipper GetShipperById(int id)
        {
            var shipper = new Shipper();
            var queryString = "SELECT * FROM dbo.Shippers WHERE ShipperID =" + id;
            using (var connection = new SqlConnection(_connectionstring))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    shipper.ShipperID = (int) reader["ShipperID"];
                    shipper.CompanyName = (string) reader["CompanyName"];
                    shipper.Phone = (string) reader["Phone"];
                }
                reader.Close();
            }
            return shipper;
        }

        public void SaveShipper(Shipper shipper)
        {
            using (var connection = new SqlConnection(_connectionstring))
            using (var command = connection.CreateCommand())
            {
                command.Parameters.AddWithValue("@companyName", shipper.CompanyName);
                command.Parameters.AddWithValue("@phone", shipper.Phone);
                command.Parameters.AddWithValue("@shipperID", shipper.ShipperID);

                command.CommandText =
                    "UPDATE Shippers SET CompanyName = @companyName, Phone = @phone WHERE ShipperID = @shipperID";

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}