using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcPractice.Models;
using MvcPractice.Database;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace MvcPractice.Repository
{

    public class ThreadRepository : IThreadRepository
    {

        public ThreadRepository()
        {
            //@todo
        }

        public Thread GetThreadByThreadId(int id)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                "SELECT * FROM Threads WHERE ID = " + id);

            List<Thread> threadList = ModelBinder.SqlDataReaderMapToList<Thread>(sqlDataReader);

            sqlDataReader.Close();
            
            return threadList[0];
        }

        public List<Thread> GetThreadsList(int page)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                "SELECT * FROM Threads");

            List<Thread> threadList = ModelBinder.SqlDataReaderMapToList<Thread>(sqlDataReader);

            sqlDataReader.Close();

            return threadList;
        }

        public int InsertNewThread(Thread newThread)
        {
            string query = "INSERT INTO Threads (Title, Content, Creator, Create_date) VALUES (@Title, @Content, @Creator, @Create_date)";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Title", newThread.Title));
            parameters.Add(new SqlParameter("@Content", newThread.Content));
            parameters.Add(new SqlParameter("@Creator", newThread.Creator));
            parameters.Add(new SqlParameter("@Create_date", newThread.Create_date));

            return SqlHelper.ExecuteNonQuery(
                DatabaseManager.GetConnectionString(),
                CommandType.Text,
                query,
                parameters.ToArray());
        }
    }
}