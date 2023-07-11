using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Models;
using System.Linq;

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
        [HttpGet("GetPosts/{id}")]
        public async Task<IActionResult> GetConnectionsPost(int id)
        {
            try
            {
                var posts1 = _context.Connection_sPosts.FromSqlRaw($"exec usp_GetConnectionsPost1 @id={id}") as IEnumerable<Connection_sPost>;
                var posts2 = _context.Connection_sPosts.FromSqlRaw($"exec usp_GetConnectionsPost2 @id={id}");
                var Likes = _context.CheckOwnPostLikes.FromSqlRaw($"exec usp_CheckLike @id={id}").ToList();
                var posts3 = _context.Connection_sPosts.FromSqlRaw($"exec usp_GetOwnPosts @id={id}");
                var both = posts1.Concat(posts2).ToList();
                var both2 = both.Concat(posts3).ToList();
                both2.Sort((a, b) => b.Post_Id - a.Post_Id);
                for(var i=0;i<both2.Count; i++)
                {
                    for(var j = 0; j < Likes.Count; j++)
                    {
                        if(both2[i].Post_Id == Likes[j].Post_Id)
                        {
                            both2[i].Status = Likes[j].Status;
                        }
                    }
                }
                for (var i = 0; i < both2.Count; i++)
                {
                    var count = _context.CountPostLikes.FromSqlRaw($"exec usp_PostLikeCount @id={both2[i].Post_Id}").ToList();
                    if(count.Count != 0)
                    {
                    if (count[0].Post_Id == both2[i].Post_Id && count.Count == 1)
                    {
                        both2[i].LikeCounts = count[0].LikeCounts;
                    }
                    }
                }
                return Ok(both2);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[EnableCors("Policy1")]
        //[HttpGet("GetPosts2/{id2}")]
        //public async Task<IActionResult> GetConnectionsPost2(int id2)
        //{
        //    try
        //    {
        //        var posts = _context.Connection_sPosts.FromSqlRaw($"exec usp_GetConnectionsPost2 @id={id2}");
        //        return Ok(posts);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //[EnableCors("Policy1")]
        //[HttpGet("GetOwnPosts/{id}")]
        //public async Task<IActionResult> GetOwnPosts(int id)
        //{
        //    try
        //    {
        //        var posts = _context.OwnPosts.FromSqlRaw($"exec usp_GetOwnPosts @id={id}");
        //        return Ok(posts);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //[EnableCors("Policy1")]
        //[HttpGet("GetLikeCounts/{id}")]
        //public async Task<IActionResult> GetLikeCounts(int id)
        //{
        //    try
        //    {
        //        var count = _context.CountPostLikes.FromSqlRaw($"exec usp_PostLikeCount @id={id}");
        //        return Ok(count);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //-------------------------------------------------------------------------------------------------------------------
        //[EnableCors("Policy1")]
        //[HttpGet("GetLikes1/{id1}")]
        //public async Task<IActionResult> GetLikes1(int id1)
        //{
        //    try
        //    {
        //        var Likes = _context.CheckPostLikes.FromSqlRaw($"exec usp_CheckLike1 @id={id1}");
        //        return Ok(Likes);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //[EnableCors("Policy1")]
        //[HttpGet("GetLikes2/{id2}")]
        //public async Task<IActionResult> GetLikes2(int id2)
        //{
        //    try
        //    {
        //        var Likes = _context.CheckPostLikes.FromSqlRaw($"exec usp_CheckLike2 @id={id2}");
        //        return Ok(Likes);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //--------------------------------------------------------------------------------------------------------------------------------
        //[EnableCors("Policy1")]
        //[HttpGet("CheckOwnPostLike/{id}")]
        //public async Task<IActionResult> CheckOwnPostLike(int id)
        //{
        //    try
        //    {
        //        var Likes = _context.CheckOwnPostLikes.FromSqlRaw($"exec usp_CheckLike @id={id}");
        //        return Ok(Likes);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
