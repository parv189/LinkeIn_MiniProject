using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpPut("{id}")]
        public ActionResult<User_Information> UpdateUser(int id, User_Information request)
        {
           
            var updateuserinfo = userInfo.Update(request);
            return updateuserinfo;
        }
    }
}
