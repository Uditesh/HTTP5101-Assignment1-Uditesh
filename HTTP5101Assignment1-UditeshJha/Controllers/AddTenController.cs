using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1_UditeshJha.Controllers
{
    public class AddTenController : ApiController
    {
        /* <summary>
         *  This method adds 10 more to integer input and returns that value.
         * </summary> 
         * <example>
         *   GET api/AddTen/{id}
         * </example>
         * <param name="id">Integer input</param> */
        public int Get(int id)
        {
            int valueAfterAddedTen = id + 10;
            return valueAfterAddedTen;
        }
    }
}
