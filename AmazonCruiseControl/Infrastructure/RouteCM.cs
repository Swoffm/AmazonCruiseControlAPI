using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonDriverCruiseControl.Infrastructure
{
    public class RouteCM
    {
        public string RouteName { get; set; }
        public float AverageMPG { get; set; }
        public float AverageCruiseControlTime { get; set; }
        public DateTime Date { get; set; }
    }
}
