﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Models;

namespace MiniProject_LinkedIn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostLikesController : ControllerBase
    {
        private readonly IPostLikes postlike;
        public PostLikesController(IPostLikes postlike)
        {
            this.postlike = postlike;
        }
        [EnableCors("Policy1")]
        [HttpPost("{id}")]
        public ActionResult<PostLikes> AddLike(int id, User_Information req)
        {
            PostLikes pl = new PostLikes();
            pl.User_Id = req.User_ID;
            pl.CreatedById = req.User_ID;
            pl.Post_Id = id;
            var newlike = postlike.Add(pl);
            return newlike;
        }
        [EnableCors("Policy1")]
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<PostLikes>> GetLikes(int id)
        {
            List<PostLikes> postLikes = postlike.Find(x=>x.Post_Id == id).ToList();
            if(postLikes == null)
            {
                return NotFound();
            }
            return postLikes;
        }
    }
}
