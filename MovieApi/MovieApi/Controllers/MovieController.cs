using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Entities;
using MovieApi.Services;
namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService service;
        public MovieController()
        {
            this.service = new MovieService();
        }
        [Route("GetAllMovies")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Movie> Movies = service.GetAll();
            return StatusCode(200, Movies);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            Movie Movie = service.GetById(id);
            return StatusCode(200, Movie);
        }
        [HttpGet]
        [Route("GetByActor/{actor}")]
        public IActionResult GetByActor(string actor)
        {
            Movie Movie = service.GetByActor(actor);
            return StatusCode(200, Movie);
        }
        [HttpGet]
        [Route("GetByActor/{language}")]
        public IActionResult GetByLanguage(string language)
        {
            Movie Movie = service.GetByLanguage(language);
            return StatusCode(200, Movie);
        }
        [HttpGet]
        [Route("GetByActor/{director}")]
        public IActionResult GetByDirector(string director)
        {
            Movie Movie = service.GetByDirector(director);
            return StatusCode(200, Movie);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Movie Movie)
        {
            service.Add(Movie);
            return StatusCode(200, Movie);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return StatusCode(200, "Movie with " + id + " Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Movie Movie)
        {
            service.Edit(Movie);
            return StatusCode(200, Movie);
        }

    }
}