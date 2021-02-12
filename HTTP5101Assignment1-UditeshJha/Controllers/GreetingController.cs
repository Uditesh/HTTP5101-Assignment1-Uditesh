using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1_UditeshJha.Controllers
{
    public class GreetingController : ApiController
    {
        /* <summary>
         *  This method returns the String "Hello World!".
         * </summary> 
         * <example>
         *  POST api/Greeting
         * </example>   */
        public String Post()
        {
            return "Hello World!";
        }

        /* <summary>
         *  This method returns the String "Greetings to {id} people!".
         * </summary>
         * <example>
         *   GET api/Greeting/{id}
         * </example>
         * <param name="id">Integer input</param> */
        public String Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
