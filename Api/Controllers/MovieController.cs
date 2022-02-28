using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcces;
using Entitys;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            using (var dbContext = new ApiDisneyContext())
            {
                return dbContext.TMovie.ToList();
            }

        }
        [HttpGet("{title}")]
        public Movie Get(string title)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                var MovieTitle = dbContext.TMovie.FirstOrDefault(x => x.Title.Equals(title));
                return MovieTitle;
            }

        }
        

        // POST api/<MovieController>
        [HttpPost]
        public Movie Post(Movie movie)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                dbContext.TMovie.Add(movie);
                dbContext.SaveChanges();
                return movie;


            }

        }

        // PUT api/<MovieController>/5
        [HttpPut]
        public Movie Put(Movie movie)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                var Characterput = dbContext.TMovie.FirstOrDefault(x => x.IdMovie.Equals(movie.IdMovie));
                Characterput.Title = movie.Title;
                Characterput.History = movie.History;
                Characterput.Date = movie.Date;

                dbContext.SaveChanges();
                return movie;

            }

        }
        // DELETE api/<MovieController>/5
        [HttpDelete]
        public bool Delete(string id)
        {
            using (var dbContext = new ApiDisneyContext())
            {
                var MovieDelete = dbContext.TMovie.FirstOrDefault(x => x.IdMovie.Equals(id));
                dbContext.TMovie.Remove(MovieDelete);

                dbContext.SaveChanges();
                return true;

            }

        }
    }
}
