using DriverMetrix.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Data.Contracts
{
    public interface IRouteRepository
    {
        IEnumerable<Routes> GetAllRoutesByDriverId(string driverId);
    }
}
