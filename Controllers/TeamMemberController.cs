using Final_Project_Group_5.Data;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {

        private readonly ILogger<TeamMemberController> _logger;

        private readonly TeamMemberContext _context;

        public TeamMemberController(ILogger<TeamMemberController> logger, TeamMemberContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.TeamMembers.ToList());
        }

    }
}