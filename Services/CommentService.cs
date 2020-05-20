using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timtro.Models;

namespace timtro.Services
{
    public class CommentService : ICommentService
    {
        private DataContext _context;
        public CommentService (DataContext context)
        {
            _context=context;
        }

        public List<Comment> GetComments()
         {
             return _context.Comments.ToList();
         }


        public Comment GetCommentById(int id)
        {
            return _context.Comments.FirstOrDefault(x=> x.CommentId==id);
        }

        public bool AddComment(Comment comment)
        {
            try
           {
            _context.Add(comment);
            _context.SaveChanges();
               
           }
           catch (System.Exception)
           {
               
               return false;
           } 
            return true;
        }

        public bool DeleteComment(int id)
        {
            try
            {
                _context.Comments.Remove(GetCommentById(id));
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }

            return true;
        }


        

        public bool UpdateComment(Comment comment)
        {
            try
            {
            var comment1 = _context.Comments.FirstOrDefault(x=> x.CommentId == comment.CommentId);
            comment1.CommentDetail=comment.CommentDetail;
            _context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        
    }
    
}