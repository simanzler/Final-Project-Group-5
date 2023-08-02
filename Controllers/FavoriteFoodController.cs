using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase
    {

        public readonly
        public FavoriteFoodController() { }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}