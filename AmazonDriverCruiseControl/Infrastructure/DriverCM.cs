using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonDriverCruiseControl.Infrastructure
{
    public class DriverCM
    {
        public string IdNumber { get; set; }
        public string CurrentRoute { get; set; }
        public List<RouteCM> Routes { get; set; }
        public float AverageCruiseControlPerRoute { get; set; }
        public float AverageCruiseControlForCurrentRoute { get; set; }
        public float CurentCruiseControlTime { get; set; }
        public float PercentileRank { get; set; }

    }
}
