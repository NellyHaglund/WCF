using System;
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
            var queryString = "SELECT ShipperID, CompanyName, Phone FROM dbo.Shippers WHERE ShipperID =" + id;
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
            throw new NotImplementedException();
        }
    }
}