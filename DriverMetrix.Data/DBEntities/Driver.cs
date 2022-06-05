using System;
using System.Collections.Generic;
using System.Text;

namespace DriverMetrix.Data.DBEntities
{
    public class Driver
    {
        public string IdNumber { get; set; }
        public string CurrentRoute { get; set; }
        public List<Routes> Routes { get; set; }
    }
}
