using System.Collections.Generic;
using timtro.Models;

namespace timtro.Services
{
    public interface ICommentService
    {
        public List<Comment> GetComments();
        public Comment GetCommentById(int id);

        public bool AddComment(Comment comment);

        public bool UpdateComment(Comment comment);

        public bool DeleteComment(int id);
    }
}