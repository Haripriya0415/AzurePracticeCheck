using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AzurePracticeCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzurePracticeCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpGet]
        public IEnumerable<MovieList> Get()
        {
            DateTime dt = DateTime.Now;
            return Operations.GetConnection().Where(p => p.Active == true && p.DateOfLaunch <= dt);

        }

        // GET: api/Customer/5
        [HttpGet("{userid}", Name = "Get Customer")]
        public object Get(int userid)
        {
            int movieCount = 0;
            List<MovieList> list = new List<MovieList>(Operations.FavoriteList(userid, ref movieCount));

            return new { list, movieCount };
        }

        // POST: api/Customer to add fav movie
        [HttpPost]
        public IActionResult Post([FromBody] List<Favorites> fav)
        {
            Operations.InsertIntoFavorites(fav);
            return Ok();
        }

        // DELETE: api/Delete fav movie
        [HttpDelete("{favId}")]
        public string Delete(int favId)
        {
            return Operations.Delete(favId);
        }


    }
}
