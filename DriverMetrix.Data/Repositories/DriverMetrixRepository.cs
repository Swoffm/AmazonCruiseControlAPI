
using DriverMetrix.Data.Contracts;
using DriverMetrix.Data.DBEntities;
using System.Threading.Tasks;

namespace DriverMetrix.Data.Repositories
{
    public class DriverMetrixRepository : IDriverMetrixRepository
    {
        public Driver GetDriverMetrixByDriverId(string driverId)
        {
            return MockData();
        }

        public Driver MockData()
        {
            Driver driver = new Driver() { IdNumber = "A243235", CurrentRoute = "River Drive" };
            return driver;
        }
    }
}
