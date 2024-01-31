using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class GreetingController : ApiController
    { public string Post()
        {
            return "hello world";
        }
      public string Get(int id)
        {
            return $"greeting to {id} people";
        }
    }
}
