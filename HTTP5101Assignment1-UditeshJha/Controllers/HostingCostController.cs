using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1_UditeshJha.Controllers
{
    public class HostingCostController : ApiController
    {
        /* <summary>
         *  charging client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,
         *  plus an additional 13% HST. The input {id} represents the number of days which has elapsed
         *  since the beginning of the hosting.
         * </summary>
         * <example>
         *   GET api/HostingCost/{id}  
         * </example>  
         * <param name="id">Number of days</param> */
        public IEnumerable<String> Get(int id)
        {
            decimal chargeForOneFortNight = 5.50M;
            decimal numberOfFortNights = Math.Floor(id / 14M) + 1;
            decimal amountChargedPerDay = (numberOfFortNights * chargeForOneFortNight);
            decimal HST = Math.Round(((amountChargedPerDay * 13) / 100), 2);
            decimal totalAmount = amountChargedPerDay + HST;
            String quotations = "\"";
            String message1 = quotations + numberOfFortNights + " fortnights at $5.50/FN = $" + amountChargedPerDay + " CAD" + quotations;
            String message2 = quotations + "HST 13% = $" + HST + " CAD" + quotations;
            String message3 = quotations + "Total = $" + totalAmount + " CAD" + quotations;
            return new String[] { message1, message2, message3 };
        }
    }
}
