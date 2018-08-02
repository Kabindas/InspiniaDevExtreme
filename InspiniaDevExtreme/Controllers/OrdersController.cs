using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using InspiniaDevExtreme.Models;
using Microsoft.AspNetCore.Mvc;

namespace InspiniaDevExtreme.Controllers {

    [Route("api/[controller]")]
    public class OrdersController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(SampleData.Orders, loadOptions);
        }

    }
}