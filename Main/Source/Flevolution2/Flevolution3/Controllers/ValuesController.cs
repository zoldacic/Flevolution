using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Flevolution3.Models;

namespace Flevolution3.Controllers
{
    public class ValuesController : ApiController
    {
        public Purse GetPurse()
        {
            return new Purse() {BribeAmount = 1, BlackmailAmount = 2, ForceAmount = 3};
        }

        // ------------------------------------ Default stuff ---------------------------------

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}