using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    public class ShipperService : IShipperService
    {
        public Shipper GetShipperById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveShipper(Shipper shipper)
        {
            throw new NotImplementedException();
        }
    }
}
