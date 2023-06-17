using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfo : ControllerBase
    {
        private readonly IUserInfoRepository userInfo;
        public UserInfo(IUserInfoRepository userInfo)
        {
            this.userInfo = userInfo;
        }
        [EnableCors("Policy1")]
        [HttpGet("{email}")]
        public ActionResult<User_Information> GetUserbyEmail(string email)
        {
            var us = userInfo.Find(x => x.Email == email).FirstOrDefault();
            if(us == null)
            {
                return NotFound();
            }
            return us;
        }
        [EnableCors("Policy1")]
        [HttpPut("{id}")]
        public ActionResult<User_Information> UpdateUserbyId(int id, User_Information request)
        {
           if(id != request.User_ID)
            {
                return BadRequest();
            }
            try
            {
            var updateuserinfo = userInfo.Update(request);
            return updateuserinfo;

            }
            catch(DbUpdateConcurrencyException)
            {
                if(userInfo.IsExist(x => x.User_ID == request.User_ID))
                {
                    throw;
                }
                else
                {
                    return NotFound();
                }
            }

        }
        [HttpGet("GetAllUsers")]
        public ActionResult<IEnumerable<User_Information>> GetUsersInfo()
        {
            return userInfo.Index().ToList();
        }
    }
}
