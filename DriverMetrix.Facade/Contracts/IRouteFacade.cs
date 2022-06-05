using DriverMetrix.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Facade.Contracts
{
    public interface IRouteFacade
    {
        public Task<IEnumerable<Routes>> GetRouteByRouteName(string routeName);
    }
}
