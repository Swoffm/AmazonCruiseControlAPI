using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonDriverCruiseControl.Controllers
{
    public abstract class BaseController<T> : Controller
    {
        protected readonly T Adapter;

        protected BaseController(T adapter)
        {
            Adapter = adapter;
        }
    }
}
