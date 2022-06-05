using DriverMetrix.Data.DBEntities;
using DriverMetrix.Facade.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Facade.Implementation
{
    public class DriverMetrixFacade : IDriverMetrixFacade
    {
        private readonly IDriverMetrixFacade _driverMetrixFacade;
        public DriverMetrixFacade(IDriverMetrixFacade driverMetrixFacade)
        {
            _driverMetrixFacade = driverMetrixFacade;
        }
        public Task<Driver> GetDriverByDriverId(string driverId)
        {
            return _driverMetrixFacade.GetDriverByDriverId(driverId);
        }
    }
}
