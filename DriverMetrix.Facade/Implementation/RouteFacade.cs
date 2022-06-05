using DriverMetrix.Data.DBEntities;
using DriverMetrix.Facade.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Facade.Implementation
{
    public class RouteFacade : IRouteFacade
    {
        private IRouteFacade _routeFacade;
        public RouteFacade(IRouteFacade routeFacade)
        {
            _routeFacade = routeFacade;
        }
        public Task<IEnumerable<Routes>> GetRouteByRouteName(string routeName)
        {
            return _routeFacade.GetRouteByRouteName(routeName);
        }
    }
}
