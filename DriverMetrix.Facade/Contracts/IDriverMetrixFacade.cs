using DriverMetrix.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Facade.Contracts
{
    public interface IDriverMetrixFacade 
    {
        Task<Driver> GetDriverByDriverId(string driverId);
    }
}
