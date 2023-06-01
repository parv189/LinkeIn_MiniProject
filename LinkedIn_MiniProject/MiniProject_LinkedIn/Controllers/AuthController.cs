using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.DTOs;
using MiniProject_LinkedIn.Models;
using System.Security.Cryptography;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserContext _context;
      
        public AuthController(UserContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordhash, out byte[] passwordsalt);

            var user = new User_Information();
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            user.Email = request.Email;
            user.PasswordHash = passwordhash;
            user.PasswordSalt = passwordsalt;

            _context.UserInformation.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);

        }
        [HttpGet("getuser")]
        public async Task<IActionResult> getdata()
        {
            var users = await _context.UserInformation.ToListAsync();
            return Ok(users);
        }
        private void CreatePasswordHash(string password, out byte[] passwordhash , out byte[] passwordsalt)
        {
            var hamc = new HMACSHA512();
            passwordsalt = hamc.Key;
            passwordhash = hamc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>Editdata(int id,User_Information request)
        {
            _context.Entry(request).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> removedata(int id)
        {
            var x = await _context.UserInformation.FindAsync(id);
            _context.UserInformation.Remove(x);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpGet]
        //public async Task<IActionResult> getConnections()
       // {
       //     var x = _context.view1.FromSqlRaw("select * from connections");
        //    return Ok(x);
       // }
        [HttpGet("Connections")]
        public async Task<IActionResult> getConnections()
        {
            var conn = await _context.UserConnections.ToListAsync();
            return Ok(conn);
        }

         [HttpPost("CreateConnections")]
         public async Task<IActionResult> postConnections()
        {
            UserConnections uc = new UserConnections();
            _context.UserConnections.Add(uc);
            return Ok(uc);
        }
    }
}
