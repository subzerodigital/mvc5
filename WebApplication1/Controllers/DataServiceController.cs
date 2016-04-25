using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    public class DataServiceController : ApiController
    {
        // GET: api/DataService
        public List<Product> Get()
        {
            var repo = new ProductRespository();
            return repo.Retrieve();
        }

        // GET: api/DataService/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DataService
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DataService/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DataService/5
        public void Delete(int id)
        {
        }
    }
}
