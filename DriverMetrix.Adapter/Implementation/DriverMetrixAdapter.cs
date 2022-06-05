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
        
        //Also assuming that the service that calls this method will be passing a set of telementray data of bool leting us know
        //Per minute at index is van idle for that time and would be sent maybe every ten minutes 

        public async Task<Driver> ProccessCurrentData(bool[] isCruiseControl, string driverId)
        {

            //Goal will be to get Driver Route Data and see if driver is on track to beat their average for that route
            try
            {
                Driver driver = await _driverMetrixFacade.GetDriverByDriverId(driverId);
                IEnumerable<Routes> routes = await DriverRouteData(driver.CurrentRoute);
                int totalCruiseControlTime = 0;
                foreach(bool isCruise in isCruiseControl)
                {
                    if(isCruise == true)
                    {
                        totalCruiseControlTime++;
                    }
                }
                //Ideally I would calculate the total cruise control time for a given period and see if they are on track

                return await _driverMetrixFacade.GetDriverByDriverId(driverId);
            }
            catch (Exception ex)
            {
                //Ideally you would log the exception in the DB
            }
        }
        public async Task<IEnumerable<Routes>> DriverRouteData(string driverRoute)
        {
            IEnumerable<Routes> driverRoutes = await _routeFacade.GetRouteByRouteName(driverRoute);

            return driverRoutes;

        }
    }
}
