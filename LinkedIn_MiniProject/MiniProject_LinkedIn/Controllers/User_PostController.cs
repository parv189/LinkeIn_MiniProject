using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_PostController : ControllerBase
    {
        private readonly IUserPost userPost;

        public User_PostController(IUserPost userPost)
        {
            this.userPost = userPost;
        }
        [EnableCors("Policy1")]
        [HttpPost("{id}")]
        public ActionResult<User_Post> newConnection(int id,User_Post request)
        {
            User_Post up = new User_Post();
            up.User_Id = id;
            up.Photo_Url = request.Photo_Url;
            up.content = request.content;
            up.CreatedById = id;
            var post = userPost.Add(up);
            return post;
        }
    }
}
