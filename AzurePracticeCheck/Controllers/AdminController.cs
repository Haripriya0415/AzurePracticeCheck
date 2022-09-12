using Microsoft.AspNetCore.Mvc;
using AzurePracticeCheck.Models;
using System.Collections.Generic;

namespace AzurePracticeCheck.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        //Get movie list
        [HttpGet]
        public IEnumerable<MovieList> Get()
        {
            return Operations.GetConnection();
        }


        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MovieList movie)
        {
            Operations.Update(id, movie);
            return Ok();
        }

        //post: api/Admin
        [HttpPost]
        public IActionResult Post([FromBody] MovieList movie)
        {
            Operations.InsertMov(movie);
            return Ok();
        }
    }
}
