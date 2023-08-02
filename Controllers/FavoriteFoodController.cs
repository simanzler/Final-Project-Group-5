using Final_Project_Group_5.Data;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase
    {

        private readonly ILogger<FavoriteFoodController> _logger;

        private readonly FavoriteFoodContext _context;

        public FavoriteFoodController(ILogger<FavoriteFoodController> logger, FavoriteFoodContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FavoriteFood);
        }

    }
}