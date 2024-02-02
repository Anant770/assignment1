using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class NumberMachineController : ApiController
    ///<summary>
    ///Performs four mathematical operations on the users input.
    ///<param name="id">user input integer</param>
    ///</summary>
    ///<return> final answer of user input input after addition, subtractions, multiply and divide </return>
    ///<example>http://localhost:61608/api/numbermachine/3 --> 11 </example>
    ///<example>http://localhost:61608/api/numbermachine/10 --> 18 </example>
    ///<example>http://localhost:61608/api/numbermachine/8 --> 16 </example>
    {
        public int Get(int id)
        {
            return id + 10 - 2 * 5 / 4; 
        }
    }
}
