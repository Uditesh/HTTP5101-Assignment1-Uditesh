using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1_UditeshJha.Controllers
{
    public class SquareController : ApiController
    {
        /* <summary>
         *  This method returns square of the value.
         * </summary>
         * <example>
         *   GET api/Square/{id}
         * </example>
         * <param name="id">Integer input</param> */
        public int Get(int id)
        {
            int squaredValue = id * id;
            return squaredValue;
        }
    }
}
