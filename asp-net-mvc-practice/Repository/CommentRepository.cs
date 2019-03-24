using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Linq;

namespace MvcPractice.Repository
{

    public class CommentRepository : ICommentRepository
    {

        ApplicationDbContext _context;

        public CommentRepository()
        {
            //@todo
            _context = new ApplicationDbContext();
        }

        public List<Comment> GetCommentsList(int threadID)
        {
            return _context.Comments.ToList();
        }

        public int InsertNewComment(Comment newComment)
        {
            _context.Comments.Add(newComment);
            return _context.SaveChanges();
        }
    }
}