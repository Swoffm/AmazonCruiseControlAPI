using DriverMetrix.Adapter.BusinessEntites;
using DriverMetrix.Adapter.Contracts;
using DriverMetrix.Data.DBEntities;
using DriverMetrix.Facade.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Adapter.Implementation
{
    //We can assume that the DB will log what the current route
    //FK in routes on the DriverId

    public class DriverMetrixAdapter : IDriverMetrixAdapter
    { 
        private readonly IRouteFacade _routeFacade;
        private readonly IDriverMetrixFacade _driverMetrixFacade;
        public DriverMetrixAdapter(IRouteFacade routeFacade, IDriverMetrixFacade driverMetrixFacade)
        {
            _routeFacade = routeFacade;
            _driverMetrixFacade = driverMetrixFacade;
        }
        public async Task<DriverBE> ProccessCurrentData(bool[] isIdiling, string driverId)
        {
            //Goal will be to get Driver Route Data and see if driver is on track to beat their average for that route
            
        }
        public async Task<DriverBE> DriverRouteData(string driverId)
        {
            try
            {
                Driver driver = await _driverMetrixFacade.GetDriverByDriverId(driverId);
                IEnumerable<Routes> driverRoutes = await _routeFacade.GetRouteByRouteName(driver.CurrentRoute);
            }
            catch(Exception ex)
            {
                //Ideally you would log the exception in the DB
            }
            
        }
    }
}
