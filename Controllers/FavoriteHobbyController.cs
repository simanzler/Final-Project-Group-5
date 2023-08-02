using Final_Project_Group_5.Data;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteHobbyController : ControllerBase
    {

        private readonly ILogger<FavoriteHobbyController> _logger;

        private readonly FavoriteHobbyContext _context;

        public FavoriteHobbyController(ILogger<FavoriteHobbyController> logger, FavoriteHobbyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.FavoriteHobbies.ToList());
        }

    }
}