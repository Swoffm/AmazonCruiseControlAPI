using System;
using System.Collections.Generic;
using System.Text;

namespace DriverMetrix.Adapter.BusinessEntites
{
    public class RoutesBE
    {
        public string RouteName { get; set; }
        public int NumberOfStops { get; set; }
        public float AverageMPG { get; set; }
        public float AverageCruiseControlTime { get; set; }
        public DateTime Date { get; set; }
    }
}
