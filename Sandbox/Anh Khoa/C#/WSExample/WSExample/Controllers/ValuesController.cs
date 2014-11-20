using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WSExample.Controllers
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class ValuesController : ApiController
    {
        // GET api/values
        public Person GetPerson()
        {
            return new Person { Name = "Khoa", Age = 24 };
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