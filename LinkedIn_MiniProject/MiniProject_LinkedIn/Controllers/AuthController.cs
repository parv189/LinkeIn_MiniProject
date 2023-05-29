using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

            var user = new UserCredentiols();
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            user.Email = request.Email;
            user.PasswordHash = passwordhash;
            user.PasswordSalt = passwordsalt;

            _context.UserCredentiols.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);

        }
        [HttpGet("getuser")]
        public async Task<IActionResult> getdata(UserCredentiols request)
        {
            
            return Ok();
        }
        private void CreatePasswordHash(string password, out byte[] passwordhash , out byte[] passwordsalt)
        {
            var hamc = new HMACSHA512();
            passwordsalt = hamc.Key;
            passwordhash = hamc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        } 
    }
}
