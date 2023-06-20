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
        public ActionResult<User_Post> AddPost(int id, User_Post request)
        {
            User_Post up = new User_Post();
            up.User_Id = id;
            up.Photo_Url = request.Photo_Url;
            up.content = request.content;
            up.CreatedById = id;
            var post = userPost.Add(up);
            return post;
        }
        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<User_Post>> GetPost(int id)
        {
            List<User_Post> post = userPost.Find(x => x.User_Id == id).ToList();
            if (post == null)
            {
                return NotFound();
            }
            return post;
        }
        [EnableCors("Policy1")]
        [HttpDelete("{id}")]
        public ActionResult<User_Post> DeletePost(int id)
        {
            try
            {
                if (!PostExists(id))
                {
                    return NotFound();
                }
                var c = userPost.Find(x => x.Post_Id == id).FirstOrDefault();
                var deletePost = userPost.Delete(c);
                return deletePost;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        private bool PostExists(int id)
        {
            return userPost.IsExist(x => x.Post_Id == id);
        }
    }
}
