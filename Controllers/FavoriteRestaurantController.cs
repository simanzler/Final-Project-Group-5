using Final_Project_Group_5.Data;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteRestaurantController : ControllerBase
    {

        private readonly ILogger<FavoriteRestaurantController> _logger;

        private readonly FavoriteRestaurantContext _context;

        public FavoriteRestaurantController(ILogger<FavoriteRestaurantController> logger, FavoriteRestaurantContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FavoriteRestaurants.ToList());
        }

    }
}