using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds ten to user input.
        /// </summary>
        /// <returns>user input plus ten </returns>
        /// <example>http://localhost:61608/api/addten/20 --> 30 </example>
        /// <example>http://localhost:61608/api/addten/5 --> 15 </example>
        /// <example>http://localhost:61608/api/addten/-9 --> 1 </example>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
