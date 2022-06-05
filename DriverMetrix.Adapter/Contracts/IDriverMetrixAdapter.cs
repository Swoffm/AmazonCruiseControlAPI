using DriverMetrix.Adapter.BusinessEntites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DriverMetrix.Adapter.Contracts
{
    public interface IDriverMetrixAdapter
    {        
        Task<DriverBE> ProcessDriverRoute(string driverId);
    }
}
