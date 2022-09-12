using Microsoft.AspNetCore.Mvc;
using AzurePracticeCheck.Models;
using System.Collections.Generic;

namespace AzurePracticeCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnonymousUserController : Controller
    {

        [HttpGet]
        public IEnumerable<MovieList> Get()
        {
            return Operations.GetConnection();
        }
    }
}
