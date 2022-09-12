using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzurePracticeCheck.Models;

namespace AzurePracticeCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : Controller
    {
        //login
        [HttpGet]
        public string Get(string username, string password)
        {
            List<UserDetails> list = Operations.UserList();
            bool user = list.Any(p => p.UserName == username && p.Password == password);
            if (user == true)
                return "true";
            return "falseSubmission";
        }

        //signup
        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] UserDetails user)
        {
            Operations.Insert(user);
            return Ok();
        }

    }
}
