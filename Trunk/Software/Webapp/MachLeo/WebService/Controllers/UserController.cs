using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DBAdapter.DataContext;
using DBAdapter.Models;
using DBAdapter.BusinessLogic;
namespace WebService.Controllers
{
    public class UserController : ApiController
        

    {
        public ApplicationDBContext db = new ApplicationDBContext();
        [HttpPost]
        [ActionName("Login")]
        public bool Login(string name, string pass) {
            var users = from u in db.Users where u.Username == name && u.Password == pass select u;
            if (users != null) return true;
            else return false;
        }
        [HttpGet]
        [ActionName("Register")]
        public bool Create(String username, String password, string fullname, string email)
        {
            UserHelper uh = new UserHelper();
            uh.AddUser(username, password, fullname, email);
            return true;
        }
        // GET api/user
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/user/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/user
        public void Post([FromBody]string value)
        {
        }

        // PUT api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
        }
    }
}
