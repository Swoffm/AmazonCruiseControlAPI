using System;
using System.Collections.Generic;
using System.Text;

namespace DriverMetrix.Data.DBEntities
{
    public class Routes
    {
        public string RouteName { get; set; }
        public float AverageMPG { get; set; }
        public int NumberOfStops { get; set; }
        public float AverageCruiseControlTime { get; set; }
        public DateTime Date { get; set; }
    }
}
