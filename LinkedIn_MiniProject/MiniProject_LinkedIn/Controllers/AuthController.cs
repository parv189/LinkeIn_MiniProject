using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors("Policy1")]
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
            user.CreatedById = user.User_ID;
            await _context.SaveChangesAsync();
            return Ok(user);
        }
        private void CreatePasswordHash(string password, out byte[] passwordhash , out byte[] passwordsalt)
            {
                var hamc = new HMACSHA512();
                passwordsalt = hamc.Key;
                passwordhash = hamc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        [HttpPost("Login")]
        public async Task<IActionResult> login(LoginDTO request)
        {
            var user = await _context.UserInformation.FirstOrDefaultAsync(x=>x.Email == request.Email);
            if(user == null)
            {
                user = await _context.UserInformation.FirstOrDefaultAsync(x=>x.PhoneNumber == request.PhoneNumber);
                if(user == null)
                {
                    return Unauthorized("Invalid Email and PhoneNumber");
                }
            }
            var hmac = new HMACSHA512(user.PasswordSalt);
            var computehash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(request.Password));
            for(int i = 0; i < computehash.Length; i++)
            {
                if (computehash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Invalid Password");
                }
            }
            return Ok(user);
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

        [HttpGet("Getuser")]
        public async Task<IActionResult> getdata()
        {
            var x = await _context.UserInformation.ToListAsync();
            return Ok(x);
        }
        [HttpGet("GetuLikes")]
        public async Task<IActionResult> getlikes()
        {
            var users = await _context.PostLikes.ToListAsync();
            return Ok(users);
        }

        //[HttpGet]
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
         public async Task<IActionResult> postConnections(UserConnections request)
        {
            UserConnections uc = new UserConnections();
            uc.User_ID = request.User_ID;
            uc.ConnectedUser_ID = request.ConnectedUser_ID;
            _context.UserConnections.Add(uc);
            await _context.SaveChangesAsync();
            uc.CreatedById = uc.User_ID;
            return Ok(uc);
        }
    }
}
