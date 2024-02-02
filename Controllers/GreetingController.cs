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
        /// <summary>
        /// Post request returns string "Hello World!"
        /// </summary>
        /// <return>"Hello World"</return>
        /// <example> In command prompt: curl -d "" http://localhost:61608/api/greeting -->"hello world!"</example>
        {
            return "hello world!";
        }
      public string Get(int id)
        {   /// <summary>
            /// Takes user input and concatenates that number to a greeting message
            /// <param name="id"/>user input integer</param>
            /// </summary>
            /// <return>"greeting to id people</return>
            /// <example>http://localhost:61608/api/greeting/3 --> greetings to 3 people!</example>
            /// <example>http://localhost:61608/api/greeting/6 --> greetings to 6 people!</example>
            /// <example>http://localhost:61608/api/greeting/0 --> greetings to 0 people!</example>
           
            return $"greetings to {id} people!";
        }
    }
}
