using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetflixShows.Model;
using NetflixShows.Context;
using Microsoft.AspNetCore.Http;

namespace NetflixShows.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private SeriesDbContext _dbContext;

        public SeriesController(SeriesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Series Get(int id)
        {
           var series =  _dbContext.Seriess.Find(id);
            return series;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Series series)
        {
            _dbContext.Seriess.Add(series);
            _dbContext.SaveChanges();

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult  Delete(int id)
        {
            var series = _dbContext.Seriess.Find(id);


            try
            {
                _dbContext.Seriess.Remove(series);
                _dbContext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
