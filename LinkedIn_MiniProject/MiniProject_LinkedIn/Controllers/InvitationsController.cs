using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationsController : ControllerBase
    {
        private readonly UserContext _context;
        public InvitationsController(UserContext context)
        {
            _context = context;
        }
        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvinations(int id)
        {
            try
            {
                var inv = _context.Invitations.FromSqlRaw($"exec usp_Invinations @id={id}");
                return Ok(inv);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
    }
}
