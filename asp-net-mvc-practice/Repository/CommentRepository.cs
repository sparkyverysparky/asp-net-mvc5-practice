using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace MvcPractice.Repository
{

    public class CommentRepository : ICommentRepository
    {
        public CommentRepository()
        {
            //@todo
        }

        public List<Comment> GetCommentsList(int threadID)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                "SELECT * FROM comment WHERE Thread_id = " + threadID);

            List<Comment> commentList = ModelBinder.SqlDataReaderMapToList<Comment>(sqlDataReader);

            sqlDataReader.Close();

            return commentList;
        }

        public int InsertNewComment(Comment newComment)
        {
            string query = "INSERT INTO comment (Content, Creator, Create_date, Thread_id) VALUES (@Content, @Creator, @Create_date, @Thread_id)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Content", newComment.Content));
            parameters.Add(new SqlParameter("@Creator", newComment.Creator));
            parameters.Add(new SqlParameter("@Create_date", newComment.Create_date));
            parameters.Add(new SqlParameter("@Thread_id", newComment.Thread_id));

            return SqlHelper.ExecuteNonQuery(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                query,
                parameters.ToArray());
        }
    }
}