using Final_Project_Group_5.Data;
using Final_Project_Group_5.Interfaces;
using Final_Project_Group_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project_Group_5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberController : ControllerBase
    {

        private readonly ILogger<TeamMemberController> _logger;

        private readonly ITeamMemberContextDAO _context;

        public TeamMemberController(ILogger<TeamMemberController> logger, ITeamMemberContextDAO context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetTeamMembers());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var member = _context.GetTeamMemberById(id);
            if (member == null)
                return NotFound(id);

            return Ok(member);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveTeamMemberById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(TeamMember member)
        {
            var result = _context.UpdateTeamMember(member);

            if (result == null)
                return NotFound(member.Id);

            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");

                return Ok();
        }

        [HttpPost]
        public IActionResult Post(TeamMember member)
        {
            var result = _context.Add(member);
            if (result == null)
                return StatusCode(500, "Member already exists");
            if (result == 0)
                return StatusCode(500, "An error occured while processing your request");
            return Ok();
        }
    }
}