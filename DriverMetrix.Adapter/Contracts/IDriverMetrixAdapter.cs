using DriverMetrix.Adapter.BusinessEntites;
using DriverMetrix.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Adapter.Contracts
{
    public interface IDriverMetrixAdapter
    {        
        Task<Driver> ProcessDriverRoute(bool[] isCruise, string driverId);
    }
}
