using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
     /// Takes user input and squares it.
     /// </summary>
     /// <param name="id"></param>
     /// <returns> squared user input </returns>
     /// <example> http://localhost:61608/api/Square/2 --> 4 </example>
     /// <example> http://localhost:61608/api/Square/-2 --> 4 </example>
     /// <example> http://localhost:61608/api/Square/10 --> 100 </example>
        public int Get(int id)
        {
            return id * id;
        }
    }
}