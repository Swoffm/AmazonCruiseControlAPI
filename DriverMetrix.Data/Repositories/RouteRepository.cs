using DriverMetrix.Data.Contracts;
using DriverMetrix.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Data.Repositories
{
    //Ideally this would obviously make a DB call for the data
    //Also makes sense that the DB would have a FK for driverId 
    //At least when getting each driver's historical data it makes it easier to think that
    
    public class RouteRepository : IRouteRepository
    {
        public IEnumerable<Routes> GetAllRoutesByDriverId(string driverId)
        {
            IEnumerable<Routes> routes = MockTestDataForRoutes();
            return routes;
        }
        private IEnumerable<Routes> MockTestDataForRoutes()
        {
            List<Routes> routes = new List<Routes>();
            Random random = new Random();
            Routes route = new Routes() { RouteName = "River Chase Drive", Date = DateTime.Now};
            for(int index = 0; index > 100; index++)
            {
                route.AverageMPG = random.Next(15);
                route.AverageCruiseControlTime = random.Next(120);
                route.NumberOfStops = random.Next(100);
                routes.Add(route);
            }
            return routes;
        }
    }
}
