using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using timtro.Models;
using timtro.Services;

namespace timtro.Controller
{
    [ApiController]
    [Route("controller")]
    public class CommentController : ControllerBase
    {
        private ICommentService _service;

        public CommentController(ICommentService service)
        {
            _service = service;
        }


        [HttpGet("/api/comment")]
        public ActionResult<List<Comment>> GetComments()
        {
            return _service.GetComments();
        }

        [HttpPost("/api/comment")]
        public ActionResult<Boolean> AddComment(Comment comment)
        {
            
            return _service.AddComment(comment);
        }

        [HttpPut("/api/comment/{id}")]
        public ActionResult<Boolean> UpdateComment(int id,Comment comment)
        {
            comment.CommentId = id;
            return _service.UpdateComment(comment);
        }

        [HttpDelete("/api/comment/{id}")]
        public ActionResult<Boolean> DeleteComment(int id)
        {
            return _service.DeleteComment(id);
        }
    }
}