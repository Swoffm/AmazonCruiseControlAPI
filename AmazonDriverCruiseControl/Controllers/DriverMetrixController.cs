using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonDriverCruiseControl.Infrastructure;
using AmazonDriverCruiseControl.Translators;
using DriverMetrix.Adapter.BusinessEntites;
using DriverMetrix.Adapter.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AmazonDriverCruiseControl.Controllers
{
    public class DriverMetrixController : BaseController<IDriverMetrixAdapter>
    {
        private readonly IDriverCM_DriverBE translator;
        public DriverMetrixController(IDriverMetrixAdapter adapter, IDriverCM_DriverBE _translator) : base(adapter)
        {
            translator = _translator;
        }

        [HttpGet]
        public async Task<ActionResult<DriverCM>> GetDriverMetrixByDriverId(string driverId)
        {
            DriverCM driverCM = new DriverCM();
            DriverBE driver = await Adapter.ProcessDriverRoute(driverId);
            return translator.DtoToEntity(driver, driverCM);
        }
    }
}
