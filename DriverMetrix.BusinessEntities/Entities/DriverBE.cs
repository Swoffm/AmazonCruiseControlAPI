using DriverMetrix.BusinessEntities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriverMetrix.BusinessEntities.BusEntities
{
    public class DriverBE
    {
        public string IdNumber { get; set; }
        public string CurrentRoute { get; set; }
        public List<RoutesBE> Routes { get; set; }
        public float AverageCruiseControlPerRoute { get; set; }
        public float AverageCruiseControlForCurrentRoute { get; set; }
        public float CurentCruiseControlTime { get; set; }
        public float PercentileRank { get; set; }
    }
}
