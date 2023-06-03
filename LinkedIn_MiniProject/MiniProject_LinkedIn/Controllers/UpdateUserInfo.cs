using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateUserInfo : ControllerBase
    {
        private readonly IUserInfoRepository userInfo;
        public UpdateUserInfo(IUserInfoRepository userInfo)
        {
            this.userInfo = userInfo;
        }
        [HttpGet("{id}")]
        public ActionResult<User_Information> GetUSerInfo(int id)
        {
            var us =  userInfo.Find(x => x.User_ID == id).FirstOrDefault();
            if(us == null)
            {
                return NotFound();
            }
            return us;
        }
        [HttpPut("{id}")]
        public ActionResult<User_Information> UpdateUser(int id, User_Information request)
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
        [HttpGet]
        public ActionResult<IEnumerable<User_Information>> GetUser()
        {
            return userInfo.Index().ToList();
        }
    }
}
