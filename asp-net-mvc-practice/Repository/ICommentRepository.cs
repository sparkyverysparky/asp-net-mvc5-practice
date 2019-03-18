using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace MvcPractice.Repository
{

    public interface ICommentRepository
    {
        List<Comment> GetCommentsList(int threadID);

        int InsertNewComment(Comment newComment);
    }
}