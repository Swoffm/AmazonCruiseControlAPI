using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonDriverCruiseControl.Infrastructure;
using DriverMetrix.Adapter.BusinessEntites;
using DriverMetrix.Adapter.Contracts;
using DriverMetrix.Data.DBEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AmazonDriverCruiseControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverMetrixController : BaseController<IDriverMetrixAdapter>
    {
        //Ideally there would be translator to create a data transfer object from the business entity or move dto to the business entity
        //private readonly IDriverCM_DriverBE translator;      
        public DriverMetrixController(IDriverMetrixAdapter adapter) : base(adapter)
        {
        }

        [HttpGet]
        public async Task<ActionResult<Driver>> GetDriverMetrixByDriverId(bool[] isCruise, string driverId)
        {
            Driver driver = await Adapter.ProcessDriverRoute(isCruise, driverId);
            return driver;
        }
    }
}
