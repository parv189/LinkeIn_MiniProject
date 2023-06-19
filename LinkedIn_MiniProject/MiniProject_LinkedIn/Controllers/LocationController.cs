using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.DTOs;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly UserContext _context;
        public LocationController(UserContext context)
        {
            _context = context;
        }
        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public async Task<IActionResult> getdata(int id)
        {
            try
            {
                var results = _context.Locations.FromSqlRaw($"exec get_Locations @i={id}");

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
