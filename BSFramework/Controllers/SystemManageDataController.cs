using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BSFramework.Controllers
{
    public class SystemManageDataController : ApiController
    {
        // GET api/systemmanagedata
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/systemmanagedata/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/systemmanagedata
        public void Post([FromBody]string value)
        {
        }

        // PUT api/systemmanagedata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/systemmanagedata/5
        public void Delete(int id)
        {
        }
    }
}
