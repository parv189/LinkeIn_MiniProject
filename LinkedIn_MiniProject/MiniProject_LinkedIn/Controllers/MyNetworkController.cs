using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyNetworkController : ControllerBase
    {
        private readonly UserContext _context;
        public MyNetworkController(UserContext context)
        {
            _context = context;
        }

        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMyNetwork(int id)
        {
            try
            {
                var network1 = _context.My_Network.FromSqlRaw($"exec usp_MyNetwork1 @id={id}") as IEnumerable<My_Network>;
                var network2 = _context.My_Network.FromSqlRaw($"exec usp_MyNetwork2 @id={id}");
                var network = network1.Concat(network2).ToList();
                return Ok(network);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
