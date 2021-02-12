using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1_UditeshJha.Controllers
{
    public class NumberMachineController : ApiController
    {
        /* <summary>
         *  This method applies four mathematical operations to the input {id} and returns the result.
         *  First 10 is added to input. Then it's multiplied by 3. Then it's devided by 2. Finally the result is subtracted by 2.
         * </summary>
         * <example>
         *   GET api/NumberMachine/{id}  
         * </example>  
         * <param name="id">Integer input</param>  */
        public decimal Get(int id)
        {
            int addedValue = id + 10;
            int multipliedValue = addedValue * 3;
            decimal dividedValue = multipliedValue / 2M;
            decimal subtractedValue = dividedValue - 2;
            decimal result = subtractedValue;
            return result;
        }
    }
}
