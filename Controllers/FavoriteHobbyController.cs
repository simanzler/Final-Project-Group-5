using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Data;
using Final_Project_Group_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteHobbyController : ControllerBase
    {

        private readonly ILogger<FavoriteHobbyController> _logger;

        private readonly IHobbyContextDAO _context;

        public FavoriteHobbyController(ILogger<FavoriteHobbyController> logger, IHobbyContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetFavoriteHobbies());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var hobby = _context.GetFavoriteHobbyById(id);
            if (hobby == null)
                return NotFound(id);

            return Ok(hobby);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveFavoriteHobbyById(id);

            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(FavoriteHobby hobby)
        {
            var result = _context.UpdateHobby(hobby);

            if (result == null)
                return NotFound(hobby.Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }

        [HttpPost]
        public IActionResult Post(FavoriteHobby hobby)
        {
            var result = _context.Add(hobby);
            if (result == null)
                return StatusCode(500, "Hobby already exists");
            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();
        }

    }
}