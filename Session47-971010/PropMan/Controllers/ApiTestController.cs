using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PropMan.Controllers
{
    public class ApiTestController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new List<string>() { "Test1", "Test2" };
        }
    }
}
