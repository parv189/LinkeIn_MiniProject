using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConnectionPostController : ControllerBase
    {
        private readonly UserContext _context;
        public ConnectionPostController(UserContext context)
        {
            _context = context;
        }
        [EnableCors("Policy1")]
        [HttpGet("GetPosts1/{id1}")]
        public async Task<IActionResult> GetConnectionsPost1(int id1)
        {
            try
            {
                var posts = _context.Connection_sPosts.FromSqlRaw($"exec usp_GetConnectionsPost1 @id={id1}");
                return Ok(posts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [EnableCors("Policy1")]
        [HttpGet("GetPosts2/{id2}")]
        public async Task<IActionResult> GetConnectionsPost2(int id2)
        {
            try
            {
                var posts = _context.Connection_sPosts.FromSqlRaw($"exec usp_GetConnectionsPost2 @id={id2}");
                return Ok(posts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [EnableCors("Policy1")]
        [HttpGet("GetOwnPosts/{id}")]
        public async Task<IActionResult> GetOwnPosts(int id)
        {
            try
            {
                var posts = _context.OwnPosts.FromSqlRaw($"exec usp_GetOwnPosts @id={id}");
                return Ok(posts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
