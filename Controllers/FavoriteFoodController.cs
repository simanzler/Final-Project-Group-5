using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase
    {

        public readonly ILogger<FavoriteFoodController> _logger;

        public FavoriteFoodController(ILogger<FavoriteFoodController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}